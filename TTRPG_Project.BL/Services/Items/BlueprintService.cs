using Microsoft.EntityFrameworkCore;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.Services.Items
{
    public class BlueprintService : BaseService<Blueprint, int>
    {
        public BlueprintService(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
