namespace TTRPG_Project.BL.DTO.Items
{
    public class ItemBaseEffectListDTO
    {
        public int Id { get; set; }
        public int? ItemBaseId { get; set; }
        public int? EffectId { get; set; }
        public string Damage { get; set; } = string.Empty;
        public int ChancePercent { get; set; }
        public bool IsDealDamage { get; set; } = false;
    }
}
