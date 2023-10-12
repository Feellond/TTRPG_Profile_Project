using System.ComponentModel.DataAnnotations.Schema;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    [Table("AttackEffectList")]
    public class AttackEffectList
    {
        public int Id { get; set; }
        public int CreatureId { get; set; }
        public int EffectId { get; set; }
        public int Damage { get; set; }
        public int ChancePercent { get; set; }
        public bool IsDealDamage { get; set; } = false;
    }
}
