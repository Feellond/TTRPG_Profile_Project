using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Project.BL.DTO.Auth.Request
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "Не указано имя пользователя")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Не указан повтор пароля")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string PasswordReply { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        public string? FullName { get; set; }
    }
}
