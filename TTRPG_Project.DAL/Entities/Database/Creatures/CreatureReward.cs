namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    public class CreatureReward
    {
        public int Id { get; set; }
        public int? CreatureId { get; set; }
        public Creature? Creature { get; set; }
        public int? RewardId { get; set; }
        public Reward? Reward { get; set; }
    }
}
