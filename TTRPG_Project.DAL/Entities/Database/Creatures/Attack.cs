using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("Attacks")]
    public class Attack : EntityDescriptionBase
    {
        public int BaseAttack { get; set; }
        public int AttackType { get; set; }
        public string Damage { get; set; } = string.Empty;
        public int Reliability { get; set; }
        public int Distance { get; set; }
        public int AttackSpeed { get; set; }
        public List<AttackEffectList> AttackEffectList { get; set; } = new();
    }
}
