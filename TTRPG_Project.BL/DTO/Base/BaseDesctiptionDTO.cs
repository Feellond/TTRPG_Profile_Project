using TTRPG_Project.DAL.Entities.Database.Additional;

namespace TTRPG_Project.BL.DTO.Base
{
    public class BaseDescriptionDTO : BaseDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Source? Source { get; set; }
        public string ImageFileName { get; set; } = string.Empty;
    }
}
