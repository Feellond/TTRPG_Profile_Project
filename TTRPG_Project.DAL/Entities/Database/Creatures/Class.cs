using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creature
{
    [Table("Classes")]
    public class Class : EntityDescriptionBase
    {
        public int Energy { get; set; }
        public List<string> MagicAbilities { get; set; } = new List<string>();

    }
}
