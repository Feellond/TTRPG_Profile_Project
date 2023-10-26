using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.Services.Creatures
{
    public class SkillsListService : BaseService<SkillsList, int>
    {
        public SkillsListService(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
    }
}
