namespace TTRPG_Project.BL.DTO.Base
{
    public class BaseItemDTO : BaseDesctiptionDTO
    {
        public int AvailabilityType { get; set; }
        public double Weight { get; set; }
        public int Price { get; set; }
        public int ItemType { get; set; }

    }
}
