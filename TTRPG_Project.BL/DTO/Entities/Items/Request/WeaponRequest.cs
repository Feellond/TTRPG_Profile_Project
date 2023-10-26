using TTRPG_Project.BL.DTO.Base;

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
        public int? SkillId { get; set; }
    }
}
