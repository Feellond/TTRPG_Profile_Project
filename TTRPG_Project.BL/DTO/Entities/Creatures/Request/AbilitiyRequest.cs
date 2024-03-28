using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class AbilitiyRequest : BaseDescriptionDTO
    {
        public int? CreatureId { get; set; }
        public int? RaceId { get; set; }
        public Race? Race { get; set; }
        public int Type { get; set; }
    }
}
