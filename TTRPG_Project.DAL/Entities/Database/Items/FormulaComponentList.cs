using System.ComponentModel.DataAnnotations.Schema;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("FormulaComponentList")]
    public class FormulaComponentList
    {
        public int Id { get; set; }
        public int? FormulaId { get; set; }
        public Formula? Formula { get; set; }
        public int? ComponentId { get; set; }
        public Component? Component { get; set; }
        public int Amount { get; set; }
    }
}
