using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Entities.Database.Users
{
   /// <summary>
   /// Таблица ролей
   /// </summary>
   [Table("Roles")]
   public class Role : IdentityRole, IEntityBase<string>
    {
        public bool Enabled { get; set; } = true;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
