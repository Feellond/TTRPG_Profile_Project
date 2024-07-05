using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class SkillsTreeResponce
    {
        public int Count { get; set; }
        public List<SkillsTreeResponceDTO>? SkillsTrees { get; set; }
    }

    public class SkillsTreeResponceDTO : SkillsTree
    {
        public Skill? MainSkill { get; set; }

        public Skill? FirstLeftSkill { get; set; }
        public Skill? SecondLeftSkill { get; set; }
        public Skill? ThirdLeftSkill { get; set; }

        public Skill? FirstMiddleSkill { get; set; }
        public Skill? SecondMiddleSkill { get; set; }
        public Skill? ThirdMiddleSkill { get; set; }

        public Skill? FirstRightSkill { get; set; }
        public Skill? SecondRightSkill { get; set; }
        public Skill? ThirdRightSkill { get; set; }
    }
}
