using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;
using TTRPG_Project.DAL.Entities.Database.Spells;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    /// <summary>
    /// Таблица существ
    /// </summary>
    [Table("Creatures")]
    public class Creature : EntityDescriptionBase
    {
        public int? RaceId { get; set; }
        public Race? Race { get; set; }
        public string AdditionalInformation { get; set; } = string.Empty;
        public int EducationSkill { get; set; } = 10;
        public string SuperstitionsInformation { get; set; } = string.Empty;
        public int MonsterLoreSkill { get; set; } = 10;
        public string MonsterLoreInformation { get; set; } = string.Empty;
        public int Complexity { get; set; } = 1;
        public int MoneyReward { get; set; } = 0; 
        public int Armor { get; set; } = 0;
        public int Regeneration { get; set; } = 0;
        public int? StatsListId { get; set; }
        public StatsList? StatsList { get; set; }
        public int? SkillsListId { get; set; }
        public SkillsList? SkillsList { get; set; }
        public int EvasionBase { get; set; }
        public int AthleticsBase { get; set; }
        public int BlockBase { get; set; }
        public int SpellResistBase { get; set; }
        public int Height { get; set; }
        public float Weight { get; set; }
        public string HabitatPlace { get; set; } = string.Empty;
        public string Intellect { get; set; } = string.Empty;
        public string GroupSize { get; set; } = string.Empty;
        public List<CreatureAttack> CreatureAttacks { get; set; } = new();
        public List<Ability> Abilities { get; set; } = new();
        public List<CreatureRewardList> CreatureRewardList { get; set; } = new();
        public List<Spell> Spells { get; set; } = new();
    }
}
