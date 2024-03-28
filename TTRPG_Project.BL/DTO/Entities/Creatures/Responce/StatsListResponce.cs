using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class StatsListResponce
    {
        public int Count { get; set; }
        public List<StatsList>? StatsLists { get; set; }
    }
}
