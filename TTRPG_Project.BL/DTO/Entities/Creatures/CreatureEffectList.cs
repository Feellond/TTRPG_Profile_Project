namespace TTRPG_Project.BL.DTO.Creatures
{
    public class CreatureEffectList
    {
        public int Id { get; set; }
        public int? CreatureId { get; set; }
        public int? EffectID { get; set; }
        public int Type { get; set; }
        public int ChancePercent { get; set; }
    }
}
