using System.ComponentModel.DataAnnotations;

namespace TTRPG_Project.BL.DTO.Auth.Request
{
    public class TokenValidationDTO
    {
        [Required]
        public string? AccessToken { get; set; }
        [Required]
        public string? RefreshToken { get; set; }
    }
}
