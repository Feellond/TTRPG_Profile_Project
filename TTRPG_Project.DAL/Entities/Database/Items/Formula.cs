using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("Formulas")]
    public class Formula : ItemBase
    {
        public int Complexity { get; set; }
        public float TimeSpend { get; set; }
        public int AdditionalPayment { get; set; }
        public List<FormulaComponentList> FormulaComponentLists { get; set; } = new();
    }
}
