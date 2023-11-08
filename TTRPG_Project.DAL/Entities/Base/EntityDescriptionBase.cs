using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Entities.Base
{
    public class EntityDescriptionBase : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
    }
}
