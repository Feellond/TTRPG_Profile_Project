using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.DAL.Entities.Database.Spells
{
    [Table("Spells")]
    public class Spell : EntityDescriptionBase
    {
        public int EnduranceCost { get; set; }
        public int Distance { get; set; }
        public string Duration { get; set; }
        public List<SpellSkillProtectionList> SpellSkillProtectionList { get; set; } = new();
        public bool IsConcetration { get; set; } = false;
        public int ConcetrationEnduranceCost { get; set; } = 0;
        public int SpellLevel { get; set; }
        public List<SpellComponentList> SpellComponentList { get; set; } = new();
        public int CheckDC { get; set; }
        public int PreparationTime { get; set; }
        public string DangerInfo { get; set; } = string.Empty;
        public string WithdrawalCondition { get; set; } = string.Empty;
        public int SpellType { get; set; }
        public string SpellTypeDescription { get; set; } = string.Empty; 
        public int SourceType { get; set; }
        public string SourceTypeDescription { get; set; } = string.Empty;
        public bool IsPriestSpell { get; set; } = false;
        public bool IsDruidSpell { get; set; } = false;
        //public List<Creature> Creatures { get; set; } = new();
    }
}
