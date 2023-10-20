using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class ClassRequest : BaseDesctiptionDTO
    {
        public int Energy { get; set; }
        public List<string> DefaultMagicAbilities { get; set; } = new List<string>();
    }
}
