using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creature
{
    /// <summary>
    /// Таблица существ
    /// </summary>
    public class Bestiary : EntityDescriptionBase
    {
        public string AdditionalInformation { get; set; } = string.Empty;
        public int EducationSkill { get; set; } = 10;
        public string SuperstitionsInformation { get; set; } = string.Empty;
        public int MonsterLoreSkill { get; set; } = 10;
        public string MonsterLoreInformation { get; set; } = string.Empty;
        public int Complexity { get; set; } = 1;
        public int MoneyReward { get; set; } = 0;
        public int Armor { get; set; } = 0;
        public int Regeneration { get; set; } = 0;
        public int StatsId { get; set; }
        public Stat Stats { get; set; }
        public int SkillsId { get; set; }
        public Skill Skills { get; set; }
        public int ResistancesListId { get; set; }
        public int ImmunitiesListId { get; set; }
        public int VulnerabilitiesListId { get; set; }
        public int EvasionBase { get; set; }
        public int AthleticsBase { get; set; }
        public int BlockBase { get; set; }
        public int Height { get; set; }
        public float Weight { get; set; }
        public string HabitatPlace { get; set; } = string.Empty;
        public string Intellect { get; set; } = string.Empty;
        public string GroupSize { get; set; } = string.Empty; 
        public int RewardListId { get; set; }
        public int AttackListId { get; set; }
        public int AbilitiesListId { get; set; }
    }
}
