using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.DTO.Auth.Request;
using TTRPG_Project.BL.DTO.Auth.Responce;
using TTRPG_Project.BL.Services.Interface;
using TTRPG_Project.DAL.Entities.Database;
using TTRPG_Project.Web.Services;

namespace TTRPG_Project.Web.Controllers.Security
{
    [AllowAnonymous]
    [Route("api/security")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public AuthController(
           UserManager<User> userManager,
           SignInManager<User> signInManager,
           IConfiguration config,
           IMapper mapper,
           IUserService userService
           )
        {
            _config = config;
            _signInManager = signInManager;
            _mapper = mapper;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest userLogin)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.GetUserByNameAsync(userLogin.Login);
                if (user != null && await _userService.CheckPasswordAsync(user, userLogin.Password))
                {
                    if (user.LockoutEnabled)
                        return BadRequest(new ErrorResponse {Message = "Пользователь заблокирован" });

                    var jwtService = new JwtService(_config);
                    var claims = await jwtService.GetClaimByUser(user, _userService.UserManager);
                    //var userRoles = await _userService.GetRolesAsync(user);

                    var token = jwtService.CreateToken(claims);
                    var refreshToken = jwtService.GenerateRefreshToken();

                    int refreshTokenValidityInDays;

                    _ = userLogin.IsRemember ?
                        int.TryParse(_config["JWT:RefreshTokenValidityInDaysIsRemebmer"], out refreshTokenValidityInDays) :
                        int.TryParse(_config["JWT:RefreshTokenValidityInDaysNotRemeber"], out refreshTokenValidityInDays);

                    user.RefreshToken = refreshToken;
                    user.IsRemember = userLogin.IsRemember;
                    user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);
                    user.LastActivity = DateTime.Now;

                    await _userService.UpdateAsync(user);

                    return Ok(new LoginResponse
                    {
                        AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                        RefreshToken = refreshToken
                    });
                }
            }
            return BadRequest();
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest model)
        {
            if (ModelState.IsValid)
            {
                var userExists = await _userService.GetUserByNameAsync(model.Username);
                if (userExists != null)
                    return BadRequest(new ErrorResponse { Message = "Пользователь уже существует"});

                var userMapped = _mapper.Map<User>(model);


                IdentityResult result = await _userService.CreateUserViaManagerAsync(userMapped, model.Password);
                if (!result.Succeeded)
                    return BadRequest(new ErrorResponse {Message = "Ошибка при создании пользователя. Проверьте правильность данных"});

                var user = await _userService.GetUserByNameAsync(userMapped.UserName);

                var jwtService = new JwtService(_config);
                var claims = await jwtService.GetClaimByUser(user, _userService.UserManager);
                //var userRoles = await _userService.GetRolesAsync(user);

                var token = jwtService.CreateToken(claims);
                var refreshToken = jwtService.GenerateRefreshToken();

                int.TryParse(_config["JWT:RefreshTokenValidityInDaysNotRemeber"], out int refreshTokenValidityInDays);

                user.RefreshToken = refreshToken;
                user.IsRemember = false;
                user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

                await _userService.UpdateAsync(user);

                return Ok(new LoginResponse
                {
                    AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                    RefreshToken = refreshToken
                });
            }
            else
                return BadRequest(new ErrorResponse { Message = "Не правильно заполнена форма регистрации" });
        }
    }
}
