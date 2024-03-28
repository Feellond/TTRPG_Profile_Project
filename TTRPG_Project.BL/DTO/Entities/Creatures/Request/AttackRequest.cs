using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class AttackRequest : BaseDescriptionDTO
    {
        public int? CreatureId { get; set; }
        public Creature? Creature { get; set; }
        public int BaseAttack { get; set; }
        public int AttackType { get; set; }
        public string Damage { get; set; } = string.Empty;
        public int Reliability { get; set; }
        public int Distance { get; set; }
        public int AttackSpeed { get; set; }
        public List<AttackEffectListDTO> AttackEffectList { get; set; } = new();
    }
}
