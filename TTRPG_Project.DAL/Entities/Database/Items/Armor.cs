using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("Armor")]
    public class Armor : ItemBase
    {
        public int Reliability { get; set; }
        public int AmountOfEnhancements { get; set; }
        public int Stiffness { get; set; }
    }
}
