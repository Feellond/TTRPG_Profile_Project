using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("Skills")]
    public class Skill : EntityDescriptionBase
    {
        public bool IsDifficult { get; set; } = false;
        public bool IsClassSkill { get; set; } = false;
        public int? StatId { get; set; }
        public Stat? Stat { get; set; }
    }
}
