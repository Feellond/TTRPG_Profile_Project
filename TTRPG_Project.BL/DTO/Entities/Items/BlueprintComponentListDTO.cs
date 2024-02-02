using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Items
{
    public class BlueprintComponentListDTO
    {
        public int? Id { get; set; }
        public int? ComponentId { get; set; }
        public Component? Component { get; set; }
        public int Amount { get; set; }
    }
}
