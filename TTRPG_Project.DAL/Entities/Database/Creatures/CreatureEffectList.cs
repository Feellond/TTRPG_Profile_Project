using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Database.Additional;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("CreatureEffectList")]
    public class CreatureEffectList
    {
        public int Id { get; set; }
        public int? CreatureId { get; set; }
        public Creature? Creature { get; set; }
        public int? EffectID { get; set; }
        public Effect? Effect { get; set; }
        public int Type { get; set; }
        public int ChancePercent { get; set; }
    }
}
