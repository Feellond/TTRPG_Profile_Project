using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.BL.DTO.Creatures;
using TTRPG_Project.BL.DTO.Items;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Entities.Items.Responce
{
    public class ItemBaseResponce : BaseItemDTO
    {
        public int? Reliability { get; set; }
        public int? AmountOfEnhancements { get; set; }
        public int? Stiffness { get; set; }
        public int? Blueprint_Complexity { get; set; }
        public float? Blueprint_TimeSpend { get; set; }
        public int? Blueprint_AdditionalPayment { get; set; }
        public string WhereToFind { get; set; } = string.Empty;
        public int? Amount { get; set; }
        public int? Component_Complexity { get; set; }
        public bool? IsAlchemical { get; set; }
        public int? SubstanceType { get; set; }
        public int? Complexity { get; set; }
        public float? TimeSpend { get; set; }
        public int? AdditionalPayment { get; set; }
        public int? StealthType { get; set; }
        public int? Type { get; set; }
        public int? Accuracy { get; set; }
        public string Damage { get; set; } = string.Empty;
        public int? Weapon_Reliability { get; set; }
        public int? Grip { get; set; }
        public int? Distance { get; set; }
        public int? Weapon_StealthType { get; set; }
        public int? Weapon_AmountOfEnhancements { get; set; }
        public bool? IsAmmunition { get; set; }
        public int? SkillId { get; set; }
        public List<FormulaComponentList>? FormulaComponentLists { get; set; }
        public List<BlueprintComponentList>? BlueprintComponentLists { get; set; }
        public Skill? Skill { get; set; }
        public int ItemType { get; set; }
    }
}
