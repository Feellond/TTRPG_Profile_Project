using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class AttackResponce
    {
        public int Count { get; set; }
        public List<Attack>? Attacks { get; set; }
    }
}
