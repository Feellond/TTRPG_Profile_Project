using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("Components")]
    public class Component : ItemBase
    {
        public string WhereToFind { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
        public int Complexity { get; set; } = 0;
        public bool IsAlchemical { get; set; } = false;
        public int SubstanceType { get; set; }
        //public List<FormulaSubstanceList> FormulaSubstanceList { get; set; } = new();
        //public List<BlueprintComponentList> BlueprintComponentList { get; set; } = new();
    }
}
