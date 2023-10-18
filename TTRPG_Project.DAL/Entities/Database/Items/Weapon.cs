using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("Weapons")]
    public class Weapon : ItemBase
    {
        public int Accuracy { get; set; }
        public string Damage { get; set; } = string.Empty;
        public int Reliability { get; set; }
        public int Grip { get; set; }
        public int Distance { get; set; }
        public int StealthType { get; set; }
        public int AmountOfEnhancements { get; set; }
        public bool IsAmmunition { get; set; }
        public int? SkillId { get; set; }
        public Skill? Skill { get; set; }
    }
}
