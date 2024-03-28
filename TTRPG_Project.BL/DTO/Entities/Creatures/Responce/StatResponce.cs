using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class StatResponce
    {
        public int Count { get; set; }
        public List<Stat>? Stats { get; set; }
    }
}
