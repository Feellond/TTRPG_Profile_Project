using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Creatures
{
    public class AttackEffectListDTO
    {
        public int? Id { get; set; }
        public int? AttackId { get; set; }
        public Attack? Attack { get; set; }
        public int? EffectId { get; set; }
        public Effect? Effect { get; set; }
        public string Damage { get; set; } = string.Empty;
        public int ChancePercent { get; set; }
        public bool IsDealDamage { get; set; } = false;
    }
}
