using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("Classes")]
    public class Class : EntityDescriptionBase
    {
        public int Energy { get; set; }
        public string DefaultMagicAbilities { get; set; } = string.Empty;
        public int? SkillsTreeId { get; set; }
        public SkillsTree? SkillsTree { get; set; }
    }
}
