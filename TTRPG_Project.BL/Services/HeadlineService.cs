using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database;

namespace TTRPG_Project.BL.Services
{
    public class HeadlineService : BaseService<Headline, int>
    {
        public HeadlineService(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
