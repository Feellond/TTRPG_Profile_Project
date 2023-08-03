using Microsoft.AspNetCore.Identity;
using TTRPG_Project.Web.Models.Enum;
using TTRPG_Project.Web.Models.Interface;

namespace TTRPG_Project.Web.Models.Database
{
    public class User : IdentityUser, IEntityBase<string>
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? FullName => $"{FirstName} {MiddleName} {LastName}";
        public string? EmailAddress { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime LastActivity { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        /// <summary>
        /// Запоминать пароль?
        /// </summary>
        public bool IsRemember { get; set; }
    }
}
