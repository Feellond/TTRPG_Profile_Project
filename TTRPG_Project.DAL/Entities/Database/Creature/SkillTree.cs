using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creature
{
    public class SkillTree : EntityDescriptionBase
    {
        public int ClassId { get; set; }
        public Class Class { get; set; }

        public int MainSkillId { get; set; }
        public int FirstLeftSkillId { get; set; }
        public int SecondLeftSkillId { get; set; }
        public int ThirdLeftSkillId { get; set; }


        public int FirstMiddleSkillId { get; set; }
        public int SecondMiddleSkillId { get; set; }
        public int ThirdMiddleSkillId { get; set; }


        public int FirstRightSkillId { get; set; }
        public int SecondRightSkillId { get; set; }
        public int ThirdRightSkillId { get; set; }

    }
}
