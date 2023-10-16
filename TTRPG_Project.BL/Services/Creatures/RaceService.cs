using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.Services.Creatures
{
    public class RaceService : BaseService<Race, int>
    {
        public RaceService(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
