using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;
using TTRPG_Project.DAL.Entities.Database.Additional;

namespace TTRPG_Project.DAL.Entities.Database.Spells
{
    [Table("SpellSkillProtectionList")]
    public class SpellSkillProtectionList
    {
        public int Id { get; set; }
        public int? SpellId { get; set; }
        public Spell? Spell { get; set; }
        public int? EffectId { get; set; }
        public Effect? Effect { get; set; }
    }
}
