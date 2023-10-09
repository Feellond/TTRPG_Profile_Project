using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Project.BL.DTO.Auth.Responce
{
    public class LoginResponse
    {
        //public string? Token { get; set; } = null;
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
