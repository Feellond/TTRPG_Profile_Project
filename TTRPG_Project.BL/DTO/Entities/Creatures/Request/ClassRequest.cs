using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Creatures.Request
{
    public class ClassRequest : BaseDescriptionDTO
    {
        public int Energy { get; set; }
        public string DefaultMagicAbilities { get; set; } = string.Empty;
    }
}
