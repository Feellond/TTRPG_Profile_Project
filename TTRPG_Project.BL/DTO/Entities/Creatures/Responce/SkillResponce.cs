using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class SkillResponce
    {
        public int Count { get; set; }
        public List<Skill>? Skills { get; set; }
    }
}
