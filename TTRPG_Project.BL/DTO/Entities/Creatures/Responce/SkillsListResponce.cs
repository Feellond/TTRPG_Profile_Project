using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class SkillsListResponce
    {
        public int Count { get; set; }
        public List<SkillsList>? SkillsLists { get; set; }
    }
}
