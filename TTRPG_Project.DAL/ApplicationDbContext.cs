using Microsoft.EntityFrameworkCore;
using TTRPG_Project.DAL.Entities.Database;

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
        public async Task<int> SaveChangeAsync()
        {
            return await base.SaveChangesAsync();
        }

        public DbSet<T> DbSet<T>() where T : class
        {
            return Set<T>();
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return Set<T>();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*builder.Entity<Competence>()
                .Property(e => e.TypeCompetence)
                .HasConversion<byte>();


            builder.Entity<User>()
            .Property(e => e.Gender)
            .HasConversion<byte>();*/

            CreateDefaultData(builder);
            base.OnModelCreating(builder);
        }

        public void CreateDefaultData(ModelBuilder builder)
        {

        }        
    }
}
