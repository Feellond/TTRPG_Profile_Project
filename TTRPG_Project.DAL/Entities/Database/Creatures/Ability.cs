using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("Abilities")]
    public class Ability : EntityDescriptionBase
    {
        //public List<Creature>? Creature { get; set; }
        public int? RaceId { get; set; }
        public Race? Race { get; set; }
        public int Type { get; set; }
        //public bool IsVulnerability { get; set; } = false;
    }
}
