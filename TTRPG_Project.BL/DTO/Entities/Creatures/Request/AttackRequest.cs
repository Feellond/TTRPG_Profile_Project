using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class AttackRequest : BaseDesctiptionDTO
    {
        public int? CreatureId { get; set; }
        public int BaseAttack { get; set; }
        public List<int> AttackType { get; set; } = new List<int>();
        public string Damage { get; set; } = string.Empty;
        public int Reliability { get; set; }
        public int Distance { get; set; }
        public int AttackSpeed { get; set; }
        public int AttackEffectListId { get; set; }
        public List<AttackEffectListDTO> AttackEffectLists { get; set; } = new();
    }
}
