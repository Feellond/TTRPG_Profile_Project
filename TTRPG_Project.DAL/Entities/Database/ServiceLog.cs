using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database
{
    public class ServiceLog : EntityBase
    {
        public int? EntityId { get; set; }
        public string Title { get; set; }
        public string LogMessage { get; set; }
    }
}
