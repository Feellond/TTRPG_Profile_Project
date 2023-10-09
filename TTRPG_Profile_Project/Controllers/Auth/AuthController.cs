using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.DTO.Login.Request;
using TTRPG_Project.BL.DTO.Login.Responce;
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
                    var userRoles = await _userService.GetRolesAsync(user);

                    var token = jwtService.CreateToken(claims);
                    var refreshToken = jwtService.GenerateRefreshToken();

                    int refreshTokenValidityInDays = 0;

                    _ = userLogin.IsRemember ?
                        int.TryParse(_config["JWT:RefreshTokenValidityInDaysIsRemebmer"], out refreshTokenValidityInDays) :
                        int.TryParse(_config["JWT:RefreshTokenValidityInDaysNotRemeber"], out refreshTokenValidityInDays);

                    user.RefreshToken = refreshToken;
                    user.IsRemember = userLogin.IsRemember;
                    user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

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
    }
}
