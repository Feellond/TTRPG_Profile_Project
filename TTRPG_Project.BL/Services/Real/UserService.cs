using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.BL.Services.Interface;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Users;

namespace TTRPG_Project.BL.Services.Real
{
    internal class UserService : BaseService<User, string>, IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserManager<User> UserManager { get { return _userManager; } }

        public UserService(UserManager<User> userManager, ApplicationDbContext dbContext) : base(dbContext)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateUserViaManagerAsync(User user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);

            return result;
        }

        public override async Task<ICollection<User>> GetAllAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User?> GetUserByNameAsync(string name)
        {
            return await _userManager.FindByNameAsync(name);
        }

        public async Task<bool> CheckPasswordAsync(User user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<IList<string>> GetRolesAsync(User user)
        {
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<IdentityResult> UpdateViaManagerAsync(User user)
        {
            return await _userManager.UpdateAsync(user);
        }

        public override async Task<User?> GetByIdAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }
    }
}
