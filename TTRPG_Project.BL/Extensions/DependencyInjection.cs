using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Partners.BL.Mappings;
using Microsoft.EntityFrameworkCore;
using TTRPG_Project.BL.Services.Interface;
using TTRPG_Project.BL.Services.Real;
using TTRPG_Project.DAL.Entities.Database;
using TTRPG_Project.DAL.Data;

namespace TTRPG_Project.BL.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceConfig(this IServiceCollection services, ConfigurationManager config)
        {

            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            services.AddAutoMapper(typeof(MappingProfile));

            //services.AddScoped<LoginService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ILogService, LogService>();

            return services;
        }
    }
}
