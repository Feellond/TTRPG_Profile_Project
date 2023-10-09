using Microsoft.AspNetCore.Identity;
using TTRPG_Project.DAL.Entities.Enum;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Entities.Database
{
    public class User : IdentityUser, IEntityBase<string>
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? FullName => $"{FirstName} {MiddleName} {LastName}";
        public string? EmailAddress { get; set; }
        public Gender? Gender { get; set; }
        public DateTime LastActivity { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        /// <summary>
        /// Запоминать пароль?
        /// </summary>
        public bool IsRemember { get; set; }
        public bool Enabled { get; set; } = true;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
