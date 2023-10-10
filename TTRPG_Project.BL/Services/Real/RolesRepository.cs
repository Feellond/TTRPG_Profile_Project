using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.BL.Services.Interface;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database;

namespace TTRPG_Project.BL.Services.Real
{
    public class RolesRepository : BaseService<Role, string>, IRolesService
    {
        public RolesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Role?> GetByIdAsync(string id)
        {
            return await _dbContext.Roles.Where(x => x.Id == id).SingleOrDefaultAsync();
        }

        public override async Task<ICollection<Role>?> GetAllAsync()
        {
            return await _dbContext.Roles.ToListAsync();
        }
    }
}
