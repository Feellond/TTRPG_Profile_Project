using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    public class CreatureReward
    {
        public int Id { get; set; }
        public int? CreatureId { get; set; }
        public Creature? Creature { get; set; }
        //public int? RewardId { get; set; }
        //public Reward? Reward { get; set; }
        public int? ItemBaseId { get; set; }
        public ItemBase? ItemBase { get; set; }
        public string Amount { get; set; } = string.Empty;
    }
}
