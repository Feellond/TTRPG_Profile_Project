using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Creatures.Responce
{
    public class SkillResponce : BaseDesctiptionDTO
    {
        public bool IsDifficult { get; set; } = false;
        public bool IsClassSkill { get; set; } = false;
        public int StatId { get; set; }
    }
}
