using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creature
{
    [Table("Attacks")]
    public class Attack : EntityDescriptionBase
    {
        public int CreatureId { get; set; }
        public int BaseAttack { get; set; }
        public List<int> AttackType { get; set; } = new List<int>();
        public int Damage { get; set; }
        public int Reliability { get; set; }
        public int Distance { get; set; }
        public int AttackSpeed { get; set; }
    }
}
