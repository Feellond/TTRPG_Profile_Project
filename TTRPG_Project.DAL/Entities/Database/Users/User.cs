using Microsoft.AspNetCore.Identity;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Entities.Database.Users
{
    /// <summary>
    /// Таблица пользователей
    /// </summary>
    public class User : IdentityUser, IEntityBase<string>
    {
        public string? FullName { get; set; }
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
