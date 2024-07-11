using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Entities.Base
{
    public class EntityDescriptionBase : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? SourceId { get; set; }
        public Source? Source { get; set; }
        public string ImageFileName { get; set; } = string.Empty;
    }
}
