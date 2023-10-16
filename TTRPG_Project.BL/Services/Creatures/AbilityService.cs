using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.Services.Creatures
{
    public class AbilityService : BaseService<Abilitiy, int>
    {
        public AbilityService(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
