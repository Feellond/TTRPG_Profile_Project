using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("Components")]
    public class Component : ItemBase
    {
        public List<string> WhereToFind { get; set; } = new List<string>();
        public int Amount { get; set; }
        public int Complexity { get; set; }
        public bool IsAlchemical { get; set; }
        public int SubstanceType { get; set; }
    }
}
