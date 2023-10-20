using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class AbilitiyRequest : BaseDesctiptionDTO
    {
        public int? CreatureId { get; set; }
        public int? RaceId { get; set; }
        public int Type { get; set; }
    }
}
