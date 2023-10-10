﻿using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database
{
    public class Skill : EntityDescriptionBase
    {
        public bool IsDifficult { get; set; } = false;
        public bool IsClassSkill { get; set; } = false;
        public int StatId { get; set; }
    }
}
