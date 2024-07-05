using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("SkillsTree")]
    public class SkillsTree : EntityDescriptionBase
    {
        public string LeftBranchName { get; set; } = string.Empty;
        public string MiddleBranchName { get; set; } = string.Empty;
        public string RightBranchName { get; set; } = string.Empty;

        public int MainSkillId { get; set; }
        public int MainSkillValue { get; set; } = 0;


        public int FirstLeftSkillId { get; set; }
        public int SecondLeftSkillId { get; set; }
        public int ThirdLeftSkillId { get; set; }
        public int FirstLeftSkillValue { get; set; } = 0;
        public int SecondLeftSkillValue { get; set; } = 0;
        public int ThirdLeftSkillValue { get; set; } = 0;


        public int FirstMiddleSkillId { get; set; }
        public int SecondMiddleSkillId { get; set; }
        public int ThirdMiddleSkillId { get; set; }
        public int FirstMiddleSkillValue { get; set; } = 0;
        public int SecondMiddleSkillValue { get; set; } = 0;
        public int ThirdMiddleSkillValue { get; set; } = 0;


        public int FirstRightSkillId { get; set; }
        public int SecondRightSkillId { get; set; }
        public int ThirdRightSkillId { get; set; }
        public int FirstRightSkillValue { get; set; } = 0;
        public int SecondRightSkillValue { get; set; } = 0;
        public int ThirdRightSkillValue { get; set; } = 0;

    }
}
