using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Additional;

namespace TTRPG_Project.BL.Services.Additional
{
    public class EffectService : BaseService<Effect, int>
    {
        public EffectService(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
