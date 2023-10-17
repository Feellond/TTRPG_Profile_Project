using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Partners.BL.Mappings;
using Microsoft.EntityFrameworkCore;
using TTRPG_Project.DAL.Entities.Database;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.BL.Services;
using TTRPG_Project.BL.Services.Users;
using TTRPG_Project.BL.Services.Items;

namespace TTRPG_Project.BL.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceConfig(this IServiceCollection services, ConfigurationManager config)
        {

            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString, b => b.MigrationsAssembly("Partners.DAL"));
            });

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseMySql(config.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 34)), b => b.MigrationsAssembly("Partners.DAL"))
            //);

            services.AddAutoMapper(typeof(MappingProfile));

            //services.AddScoped<LoginService>();
            services.AddScoped<UserService>();
            services.AddScoped<LogService>();
            services.AddScoped<ItemBaseService>();

            return services;
        }
    }
}
