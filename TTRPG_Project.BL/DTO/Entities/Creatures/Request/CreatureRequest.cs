﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Spells;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class CreatureRequest : BaseDescriptionDTO
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
        public StatsList? StatsList { get; set; } = new StatsList();
        public int? SkillsListId { get; set; }
        public SkillsList? SkillsList { get; set; } = new SkillsList();
        //public List<CreatureEffectListDTO> CreatureEffectList { get; set; } = new();
        public int EvasionBase { get; set; } = 0;
        public int AthleticsBase { get; set; } = 0;
        public int BlockBase { get; set; } = 0;
        public int SpellResistBase { get; set; } = 0;
        public int Height { get; set; } = 0;
        public float Weight { get; set; } = 0;
        //public string Vulnerabilities { get; set; } = string.Empty;
        //public string Immunities { get; set; } = string.Empty;
        //public string Resistances { get; set; } = string.Empty;
        public List<CreatureEffect> CreatureEffects { get; set; } = new();
        public string HabitatPlace { get; set; } = string.Empty;
        public string Intellect { get; set; } = string.Empty;
        public string GroupSize { get; set; } = string.Empty;
        public string ImageFileName { get; set; } = string.Empty;
        //public IFormFile? File { get; set; }
        public List<CreatureAttack> CreatureAttacks { get; set; } = new();
        public List<CreatureAbility> CreatureAbilitys { get; set; } = new();
        public List<CreatureReward> CreatureReward { get; set; } = new();
        public List<Spell> Spells { get; set; } = new();
        public Mutagen? Mutagen { get; set; }
        public Trophy? Trophy { get; set; }
    }
}
