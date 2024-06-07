using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.DAL.Entities.Database.Spells
{
    [Table("Spells")]
    public class Spell : EntityDescriptionBase
    {
        public int EnduranceCost { get; set; } = 0;
        public int Distance { get; set; } = 0;
        public string Duration { get; set; } = string.Empty;
        public List<SpellSkillProtectionList> SpellSkillProtectionList { get; set; } = new();
        public bool IsConcentration { get; set; } = false;
        public int ConcentrationEnduranceCost { get; set; } = 0;
        public int SpellLevel { get; set; } = 0;
        public List<SpellComponentList> SpellComponentList { get; set; } = new();
        public int CheckDC { get; set; } = 0;
        public int PreparationTime { get; set; } = 0;
        public string DangerInfo { get; set; } = string.Empty;
        public string WithdrawalCondition { get; set; } = string.Empty;
        public int SpellType { get; set; } = 0;
        public string SpellTypeDescription { get; set; } = string.Empty; 
        public int SourceType { get; set; } = 0;
        public string SourceTypeDescription { get; set; } = string.Empty;
        public bool IsPriestSpell { get; set; } = false;
        public bool IsDruidSpell { get; set; } = false;
        public string ImageFileName { get; set; } = string.Empty;
        //public List<Creature> Creatures { get; set; } = new();
    }
}
