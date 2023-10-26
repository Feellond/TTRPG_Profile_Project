using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("Abilities")]
    public class Abilitiy : EntityDescriptionBase
    {
        public int? CreatureId { get; set; }
        public Creature? Creature { get; set; }
        public int? RaceId { get; set; }
        public Race? Race { get; set; }
        public int Type { get; set; }
    }
}
