namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    public class CreatureAbility
    {
        public int Id { get; set; }
        public int? CreatureId { get; set; }
        public Creature? Creature { get; set; }
        public int? AbilityId { get; set; }
        public Ability? Ability { get; set; }
    }
}
