using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Partners.BL.Mappings;
using TTRPG_Project.DAL.Entities.Database;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.BL.Services;
using TTRPG_Project.BL.Services.Users;
using TTRPG_Project.BL.Services.Items;
using TTRPG_Project.BL.Services.Additional;
using TTRPG_Project.BL.Services.Creatures;

namespace TTRPG_Project.BL.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceConfig(this IServiceCollection services, ConfigurationManager config)
        {

            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString, b => b.MigrationsAssembly("TTRPG_Project.DAL"))
            );

            //services.AddDbContext<ApplicationDbContext>(options =>
            //{
            //    options.UseNpgsql(connectionString, b => b.MigrationsAssembly("TTRPG_Project.DAL"));
            //});

            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseMySql(config.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 34)), b => b.MigrationsAssembly("Partners.DAL"))
            //);

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<EffectService>();
            services.AddScoped<ServicePriceService>();
            services.AddScoped<SourceService>();

            services.AddScoped<AbilityService>();
            services.AddScoped<AttackService>();
            services.AddScoped<ClassService>();
            services.AddScoped<CreatureService>();
            services.AddScoped<RaceService>();
            services.AddScoped<SkillService>();
            services.AddScoped<SkillsListService>();
            services.AddScoped<SkillsTreeService>();
            services.AddScoped<StatService>();
            services.AddScoped<StatsListService>();

            services.AddScoped<AlchemicalItemService>();
            services.AddScoped<ArmorService>();
            services.AddScoped<BlueprintService>();
            services.AddScoped<ComponentService>();
            services.AddScoped<FormulaService>();
            services.AddScoped<ItemBaseService>();
            services.AddScoped<ItemService>();
            services.AddScoped<ToolService>();
            services.AddScoped<WeaponService>();

            services.AddScoped<JwtService>();
            services.AddScoped<RoleService>();
            services.AddScoped<UserService>();

            services.AddScoped<LogService>();
            services.AddScoped<HeadlineService>();

            return services;
        }
    }
}
