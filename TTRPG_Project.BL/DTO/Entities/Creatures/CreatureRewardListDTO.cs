namespace TTRPG_Project.BL.DTO.Creatures
{
    public class CreatureRewardListDTO
    {
        public int Id { get; set; }
        public int? CreatureId { get; set; }
        public int? ItemBaseId { get; set; }
        public string Amount { get; set; } = string.Empty;
    }
}
