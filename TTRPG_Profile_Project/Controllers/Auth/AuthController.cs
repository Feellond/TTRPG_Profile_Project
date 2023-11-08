using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.DTO.Auth.Request;
using TTRPG_Project.BL.DTO.Auth.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.Services.Users;
using TTRPG_Project.DAL.Entities.Database.Users;

namespace TTRPG_Project.Web.Controllers.Security
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IConfiguration _config;
        private readonly JwtService _jwtService;

        public AuthController( UserService userService, JwtService jwtService, IConfiguration config)
        {
            _userService = userService;
            _jwtService = jwtService;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest userLogin)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.GetUserByNameAsync(userLogin.Login);
                if (user is null)
                    BadRequest(new ErrorResponse { Message = "Пользователь не найден!" });

                if (!await _userService.CheckPasswordAsync(user, userLogin.Password))
                    BadRequest(new ErrorResponse { Message = "Пароли не совпадают!" });

                if (!user.Enabled)
                    BadRequest(new ErrorResponse { Message = "Пользователь удален!" });

                var responce = await _userService.LoginAsync(user, userLogin.IsRemember);
                return Ok(responce);
            }
            return BadRequest(new ErrorResponse { Message = "Не правильно заполнена форма авторизации!" });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest model)
        {
            if (ModelState.IsValid)
            {
                var userExists = await _userService.GetUserByNameAsync(model.Username);
                if (userExists != null)
                    BadRequest(new ErrorResponse { Message = "Пользователь уже существует!" });

                var responce = await _userService.RegisterAsync(model);
                return Ok(responce);
            }
            else
                return BadRequest(new ErrorResponse { Message = "Не правильно заполнена форма регистрации" });
        }

        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> LogOut()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                string username = identity?.Name;
                if (!string.IsNullOrEmpty(username))
                {
                    var user = await _userService.GetUserByNameAsync(username);
                    if (user != null)
                    {
                        user.RefreshToken = null;
                        await _userService.UpdateAsync(user);
                    }
                }
            }

            return Ok();
        }

        [Authorize(Roles = Roles.ADMINISTRATOR)]
        [HttpPost]
        [Route("revoke/{username}")]
        public async Task<IActionResult> Revoke(string username)
        {
            var user = await _userService.GetUserByNameAsync(username);
            if (user == null) return BadRequest("Invalid user name");

            user.RefreshToken = null;
            await _userService.UpdateAsync(user);

            return NoContent();
        }

        [Authorize(Roles = Roles.ADMINISTRATOR)]
        [HttpPost]
        [Route("revoke-all")]
        public async Task<IActionResult> RevokeAll()
        {
            var users = await _userService.GetAllAsync();
            foreach (var user in users)
            {
                user.RefreshToken = null;
                await _userService.UpdateAsync(user);
            }

            return NoContent();
        }

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken(TokenValidationDTO tokenModel)
        {
            if (ModelState.IsValid)
            {
                var principal = _jwtService.GetClaimDataFromToken(tokenModel.AccessToken);
                if (principal == null)
                    return BadRequest("Invalid access token");

                string username = principal.Identity.Name;
                var user = await _userService.GetUserByNameAsync(username);

                if (user == null || user.RefreshToken != tokenModel.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                    return BadRequest("Invalid access token");

                var claims = await _jwtService.GetClaimByUser(user, _userService.UserManager);
                var newAccessToken = _jwtService.CreateToken(claims);
                var newRefreshToken = _jwtService.GenerateRefreshToken();
                int refreshTokenValidityInDays = 0;
                _ = user.IsRemember ?
                    int.TryParse(_config["JWT:RefreshTokenValidityInDaysIsRemebmer"], out refreshTokenValidityInDays) :
                    int.TryParse(_config["JWT:RefreshTokenValidityInDaysNotRemeber"], out refreshTokenValidityInDays);


                user.RefreshToken = newRefreshToken;
                user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);
                await _userService.UpdateAsync(user);
                return new ObjectResult(new LoginResponse
                {
                    AccessToken = new JwtSecurityTokenHandler().WriteToken(newAccessToken),
                    RefreshToken = newRefreshToken,
                });
            }

            return BadRequest("Invalid client request");
        }
    }
}
