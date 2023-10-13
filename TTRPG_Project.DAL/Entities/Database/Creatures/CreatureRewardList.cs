using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("CreatureRewardList")]
    public class CreatureRewardList
    {
        public int Id { get; set; }
        public int CreatureId { get; set; }
        public Creature Creature { get; set; }
        public int ItemBaseId { get; set; }
        public ItemBase ItemBase { get; set; }
    }
}
