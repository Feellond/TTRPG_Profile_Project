using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("CreatureRewardList")]
    public class CreatureRewardList
    {
        public int Id { get; set; }
        public List<Creature> Creature { get; set; } = new();
        public int? ItemBaseId { get; set; }
        public ItemBase? ItemBase { get; set; }
        public string Amount { get; set; } = string.Empty;
    }
}
