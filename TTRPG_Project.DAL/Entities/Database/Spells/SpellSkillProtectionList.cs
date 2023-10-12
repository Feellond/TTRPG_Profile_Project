using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Spells
{
    [Table("SpellSkillProtectionList")]
    public class SpellSkillProtectionList : EntityBase
    {
        public int SpellId { get; set; }
        public int EffectId { get; set; }
    }
}
