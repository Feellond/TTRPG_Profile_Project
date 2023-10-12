using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using TTRPG_Project.BL.Const;
using TTRPG_Project.DAL.Entities.Database.Users;

namespace TTRPG_Project.DAL.Data
{
    public static class InitSettings
    {
        public const string ADMIN_USERNAME = "Admin";
        public const string SYSTEM_USERNAME = "System";

        private static string defaultPassword = "1qaz@WSX";
        private static string systemPassword = "oyzt6NN1J4gXJr8wsMc0";


        public static async System.Threading.Tasks.Task IdentityInicializer(IApplicationBuilder app)
        {
            var serviceProvider = app.ApplicationServices;
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var userManager = (UserManager<User>?)scope.ServiceProvider.GetService(typeof(UserManager<User>));
                var roleManager = (RoleManager<Role>?)scope.ServiceProvider.GetService(typeof(RoleManager<Role>));
                var roles = new List<string>() { 
                    Roles.ADMINISTRATOR,
                    Roles.MODERATOR,
                    Roles.USER,
                };

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                    {
                        var createRole = new Role
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = role,
                            CreateDate = DateTime.Now,
                            UpdateDate = DateTime.Now,
                        };
                        await roleManager.CreateAsync(createRole);
                    }
                }

                await CreateIfNotExistUser(userManager, ADMIN_USERNAME, "Администратор системы", defaultPassword, "email@mail.ru");
                await CreateIfNotExistUser(userManager, SYSTEM_USERNAME, "Система", systemPassword, "email@mail.ru");
            }
        }

        public static async Task CreateIfNotExistUser(
            UserManager<User> userManager,
            string userName,
            string name,
            string password,
            string email
            )
        {
            if (await userManager.FindByNameAsync(userName) == null)
            {
                User user = new User
                {
                    UserName = userName,
                    FullName = name,
                    NormalizedUserName = userName.ToUpper(),
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    LastActivity = DateTime.Now,
                    Email = email,
                };

                IdentityResult result = await userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, Roles.ADMINISTRATOR);
                    await userManager.AddToRoleAsync(user, Roles.MODERATOR);
                    await userManager.AddToRoleAsync(user, Roles.USER);
                }
            }
        }

        
    }
}

