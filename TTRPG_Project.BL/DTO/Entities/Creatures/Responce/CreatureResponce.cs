using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class CreatureResponce
    {
        public int Count { get; set; }
        public List<CreatureDTO> Entitys { get; set; }
    }
}
