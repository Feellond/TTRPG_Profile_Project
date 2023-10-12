using System.ComponentModel.DataAnnotations.Schema;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("CreatureStatusList")]
    public class CreatureStatusList
    {
        public int Id { get; set; }
        public int CreatureId { get; set; }
        public int StatusId { get; set; }
        public int Type { get; set; }
        public int ChancePercent { get; set; }
    }
}
