using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class AbilityResponce
    {
        public int Count { get; set; }
        public List<Ability>? Abilities { get; set; }
    }
}
