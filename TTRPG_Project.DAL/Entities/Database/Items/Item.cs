using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("Items")]
    public class Item : ItemBase
    {
        public int StealthType { get; set; }
        public int Type { get; set; }
    }
}
