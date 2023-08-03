using Microsoft.EntityFrameworkCore;
using TTRPG_Project.Web.Models.Database;

namespace TTRPG_Project.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
            .Property(e => e.Gender)
            .HasConversion<byte>();

            CreateDefaultData(builder);
            base.OnModelCreating(builder);
        }

        public void CreateDefaultData(ModelBuilder builder)
        {

        }        
    }
}
