using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("Components")]
    public class Component : ItemBase
    {
        public string WhereToFind { get; set; } = string.Empty;
        public int Amount { get; set; }
        public int Complexity { get; set; }
        public bool IsAlchemical { get; set; }
        public int SubstanceType { get; set; }
        public List<FormulaComponentList> FormulaComponentLists { get; set; } = new();
        public List<BlueprintComponentList> BlueprintComponentLists { get; set; } = new();
    }
}
