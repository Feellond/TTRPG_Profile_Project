using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Entities.Database.Users;

namespace TTRPG_Project.BL.Services.Interface
{
    public interface IUserService : IBaseService<User, string>
    {
        UserManager<User> UserManager { get; }

        Task<bool> CheckPasswordAsync(User user, string password);
        Task<IdentityResult> CreateUserViaManagerAsync(User user, string password);
        Task<IList<string>> GetRolesAsync(User user);
        Task<User?> GetUserByNameAsync(string name);
        Task<IdentityResult> UpdateViaManagerAsync(User user);
    }
}
