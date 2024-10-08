﻿using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class SkillsTreeRequest : BaseDescriptionDTO
    {
        public int? ClassId { get; set; }
        public Class? Class { get; set; }

        public int MainSkillId { get; set; }
        public int MainSkillValue { get; set; }


        public int FirstLeftSkillId { get; set; }
        public int SecondLeftSkillId { get; set; }
        public int ThirdLeftSkillId { get; set; }
        public int FirstLeftSkillValue { get; set; }
        public int SecondLeftSkillValue { get; set; }
        public int ThirdLeftSkillValue { get; set; }


        public int FirstMiddleSkillId { get; set; }
        public int SecondMiddleSkillId { get; set; }
        public int ThirdMiddleSkillId { get; set; }
        public int FirstMiddleSkillValue { get; set; }
        public int SecondMiddleSkillValue { get; set; }
        public int ThirdMiddleSkillValue { get; set; }


        public int FirstRightSkillId { get; set; }
        public int SecondRightSkillId { get; set; }
        public int ThirdRightSkillId { get; set; }
        public int FirstRightSkillValue { get; set; }
        public int SecondRightSkillValue { get; set; }
        public int ThirdRightSkillValue { get; set; }
    }
}
