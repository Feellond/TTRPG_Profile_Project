using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Entities.Items
{
    public class ItemBaseInfo : BaseItemDTO
    {
        public int? Reliability { get; set; }
        public int? AmountOfEnhancements { get; set; }
        public int? Stiffness { get; set; }
        //public int? Blueprint_Complexity { get; set; }
        //public float? Blueprint_TimeSpend { get; set; }
        //public int? Blueprint_AdditionalPayment { get; set; }
        public string WhereToFind { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
        public int? Component_Complexity { get; set; }
        public bool? IsAlchemical { get; set; }
        public int? SubstanceType { get; set; }
        public int? Complexity { get; set; }
        public float? TimeSpend { get; set; }
        public int? AdditionalPayment { get; set; }
        public int? StealthType { get; set; }
        public int? Type { get; set; }
        public int? Accuracy { get; set; }
        public int? EquipmentType { get; set; }
        public int? ItemOriginType { get; set; }
        public string Damage { get; set; } = string.Empty;
        //public int? Weapon_Reliability { get; set; }
        public int? Grip { get; set; }
        public int? Distance { get; set; }
        //public int? Weapon_StealthType { get; set; }
        //public int? Weapon_AmountOfEnhancements { get; set; }
        public bool? IsAmmunition { get; set; }
        public int? SkillId { get; set; }
        public List<FormulaSubstanceList>? FormulaSubstanceList { get; set; } = new();
        public List<BlueprintComponentList>? BlueprintComponentList { get; set; } = new();
        public List<ItemBaseEffectList> ItemBaseEffectList { get; set; } = new();
        public List<CreatureRewardList> CreatureRewardList { get; set; } = new();
        public Skill? Skill { get; set; }
        public int ItemType { get; set; }
    }
}
