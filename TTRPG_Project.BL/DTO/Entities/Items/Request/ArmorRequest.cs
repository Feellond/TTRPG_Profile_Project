using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Items.Request
{
    public class ArmorRequest : BaseItemDTO
    {
        public int Type { get; set; }
        public int Reliability { get; set; }
        public int AmountOfEnhancements { get; set; }
        public int Stiffness { get; set; }
        public int ItemOriginType { get; set; }
        public int EquipmentType { get; set; }
    }
}
