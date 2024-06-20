using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class RaceResponce
    {
        public int Count { get; set; }
        public List<Race>? Entitys { get; set; }
    }
}
