using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Creatures
{
    public class CreatureRewardListDTO
    {
        public int? Id { get; set; }
        public int? CreatureId { get; set; }
        public int? ItemBaseId { get; set; }
        public ItemBase? ItemBase { get; set; }
        public string Amount { get; set; } = string.Empty;
    }
}
