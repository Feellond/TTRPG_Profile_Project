using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Spells;

namespace TTRPG_Project.BL.DTO.Entities.Spells.Request
{
    public class SpellRequest : BaseDescriptionDTO
    {
        public int EnduranceCost { get; set; }
        public int Distance { get; set; }
        public int Duration { get; set; }
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
        public List<Creature> Creatures { get; set; } = new();
    }
}
