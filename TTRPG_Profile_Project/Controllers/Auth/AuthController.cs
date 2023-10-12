using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
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

        public AuthController( UserService userService )
        {
            _userService = userService;
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
    }
}
