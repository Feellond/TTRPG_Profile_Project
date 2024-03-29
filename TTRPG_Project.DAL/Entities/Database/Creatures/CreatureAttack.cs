namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    public class CreatureAttack
    {
        public int Id { get; set; }
        public int? CreatureId { get; set; }
        public Creature? Creature { get; set; }
        public int? AttackId { get; set; }
        public Attack? Attack { get; set; }
    }
}
