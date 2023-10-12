namespace TTRPG_Project.DAL.Entities.Base
{
    public class EntityItemBase : EntityDescriptionBase
    {
        public int AvailabilityType { get; set; }
        public float Weight { get; set; }
        public int Price { get; set; }
    }
}
