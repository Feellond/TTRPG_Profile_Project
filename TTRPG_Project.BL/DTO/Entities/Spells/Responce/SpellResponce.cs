using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Spells;

namespace TTRPG_Project.BL.DTO.Entities.Spells.Responce
{
    public class SpellResponce
    {
        public int Count { get; set; }
        public List<Spell> Entitys { get; set; }
    }
}
