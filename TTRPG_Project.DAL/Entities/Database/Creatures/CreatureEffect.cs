using TTRPG_Project.DAL.Entities.Base;
using TTRPG_Project.DAL.Entities.Database.Additional;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    public class CreatureEffect : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? CreatureId { get; set; }
        public Creature? Creature { get; set; }
        public int? EffectId { get; set; }
        public Effect? Effect { get; set; }
        public int Type { get; set; }
    }
}
