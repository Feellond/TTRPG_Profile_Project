using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creature
{
    [Table("Abilitiies")]
    public class Abilitiy : EntityDescriptionBase
    {
        public int CreatureId { get; set; }
        public int RaceId { get; set; }
        public int Type { get; set; }
    }
}
