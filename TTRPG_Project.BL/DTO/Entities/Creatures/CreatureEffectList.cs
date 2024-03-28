using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Creatures
{
    public class CreatureEffectListDTO
    {
        public int Id { get; set; }
        public int? CreatureId { get; set; }
        public Creature? Creature { get; set; }
        public int? EffectId { get; set; }
        public Effect? Effect { get; set; }
        public int Type { get; set; }
        public int ChancePercent { get; set; }
    }
}
