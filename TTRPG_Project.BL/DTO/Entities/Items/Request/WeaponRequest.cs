using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Items.Request
{
    public class WeaponRequest : BaseItemDTO
    {
        public int Accuracy { get; set; }
        public string Damage { get; set; } = string.Empty;
        public int Reliability { get; set; }
        public int Grip { get; set; }
        public int Distance { get; set; }
        public int StealthType { get; set; }
        public int AmountOfEnhancements { get; set; }
        public bool IsAmmunition { get; set; }
        public int Type { get; set; }
        public int EquipmentType { get; set; }
        public int ItemOriginType { get; set; }
        public int? SkillId { get; set; }
        public Skill? Skill { get; set; }
    }
}
