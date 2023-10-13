using System.ComponentModel.DataAnnotations.Schema;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("BlueprintComponentList")]
    public class BlueprintComponentList
    {
        public int Id { get; set; }
        public int BlueprintId { get; set; }
        public Blueprint Blueprint { get; set; }
        public int ComponentId { get; set; }
        public Component Component { get; set; }
        public int Amount { get; set; }
    }
}
