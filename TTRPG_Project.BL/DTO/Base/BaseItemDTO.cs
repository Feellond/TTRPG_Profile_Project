using TTRPG_Project.BL.DTO.Creatures;
using TTRPG_Project.BL.DTO.Items;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Base
{
    public class BaseItemDTO : BaseDescriptionDTO
    {
        public int AvailabilityType { get; set; }
        public double Weight { get; set; }
        public int Price { get; set; }
        public int ItemType { get; set; }
        public List<ItemBaseEffectList> ItemBaseEffectList { get; set; } = new();
        public List<CreatureReward> CreatureRewardList { get; set; } = new();
    }
}
