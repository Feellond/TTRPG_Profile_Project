using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Items.Request
{
    public class ItemRequest : BaseItemDTO
    {
        public int StealthType { get; set; }
        public int Type { get; set; }
    }
}
