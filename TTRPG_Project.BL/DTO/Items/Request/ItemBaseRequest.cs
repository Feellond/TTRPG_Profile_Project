using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.BL.DTO.Creatures;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Items.Request
{
    public class ItemBaseRequest : BaseDesctiptionDTO
    {
        public int AvailabilityType { get; set; }
        public float Weight { get; set; }
        public int Price { get; set; }
        public List<ItemBaseEffectListDTO> ItemBaseEffectLists { get; set; } = new();
        public List<CreatureRewardListDTO> CreatureRewardLists { get; set; } = new();
    }
}
