using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class SkillRequest : BaseDescriptionDTO
    {
        public bool IsDifficult { get; set; } = false;
        public bool IsClassSkill { get; set; } = false;
        public int? StatId { get; set; }
        public Stat? Stat { get; set; }
    }
}
