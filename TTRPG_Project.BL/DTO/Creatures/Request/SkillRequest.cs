using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class SkillRequest : BaseDesctiptionDTO
    {
        public bool IsDifficult { get; set; } = false;
        public bool IsClassSkill { get; set; } = false;
        public int StatId { get; set; }
    }
}
