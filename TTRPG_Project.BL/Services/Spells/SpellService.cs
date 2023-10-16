using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Spells;

namespace TTRPG_Project.BL.Services.Spells
{
    public class SpellService : BaseService<Spell, int>
    {
        public SpellService(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
