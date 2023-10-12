using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creature
{
    [Table("SkillsTree")]
    public class SkillsTree : EntityDescriptionBase
    {
        public int ClassId { get; set; }

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
