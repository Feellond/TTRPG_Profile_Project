using TTRPG_Project.BL.DTO.Creatures;
using TTRPG_Project.BL.DTO.Items;

namespace TTRPG_Project.BL.DTO.Base
{
    public class BaseItemDTO : BaseDesctiptionDTO
    {
        public int AvailabilityType { get; set; }
        public double Weight { get; set; }
        public int Price { get; set; }
        public int ItemType { get; set; }
        public List<ItemBaseEffectListDTO> ItemBaseEffectList { get; set; } = new();
        public List<CreatureRewardListDTO> CreatureRewardList { get; set; } = new();
    }
}
