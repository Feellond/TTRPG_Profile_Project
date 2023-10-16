using TTRPG_Project.DAL.Entities.Database;

namespace TTRPG_Project.BL.DTO.Logs
{
    public class LogResponse
    {
        public List<ServiceLog> Logs { get; set; } = new List<ServiceLog>();
        public int TotalPages { get; set; }
    }
}
