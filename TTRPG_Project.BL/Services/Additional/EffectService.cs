using Microsoft.EntityFrameworkCore;
using TTRPG_Project.BL.DTO.Entities.Items.Responce;
using TTRPG_Project.BL.DTO.Entities.Items;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.BL.DTO.Entities.Additional.Responce;

namespace TTRPG_Project.BL.Services.Additional
{
    public class EffectService : BaseService<Effect, int>
    {
        public EffectService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<EffectResponce> GetAllAsync()
        {
            var effects = await _dbContext.Effects.AsNoTracking()
                .Include(s => s.Source).ToListAsync();

            EffectResponce responce = new()
            {
                Count = effects.Count,
                Effects = effects,
            };

            return responce;
        }
    }
}
