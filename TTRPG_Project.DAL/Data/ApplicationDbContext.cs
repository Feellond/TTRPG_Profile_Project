using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TTRPG_Project.DAL.Entities.Database;
using TTRPG_Project.DAL.Entities.Interface;
using TTRPG_Project.DAL.Repositories;

namespace TTRPG_Project.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string>, IDbRepository
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ServiceLog> ServiceLogs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public override int SaveChanges()
        {
            UpdateDate();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            UpdateDate();
            return await base.SaveChangesAsync();
        }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateDate();
            return await base.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<T> Get<T>() where T : class, IEntityBase<T>
        {
            return base.Set<T>().Where(x => x.Enabled).AsQueryable();
        }

        public IQueryable<T> Get<T>(Expression<Func<T, bool>> selector) where T : class, IEntityBase<T>
        {
            return base.Set<T>().Where(selector).Where(x => x.Enabled).AsQueryable();
        }

        async Task<T> IDbRepository.Add<T>(T newEntity)
        {
            var entity = await base.Set<T>().AddAsync(newEntity);
            return entity.Entity.Id;
        }

        public async Task AddRange<T>(IEnumerable<T> newEntities) where T : class, IEntityBase<T>
        {
            await base.Set<T>().AddRangeAsync(newEntities);
        }

        public async Task Delete<T>(T id) where T : class, IEntityBase<T>
        {
            var activeEntity = await base.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (activeEntity != null)
            {
                activeEntity.Enabled = false;
                await Task.Run(() => base.Update(activeEntity));
            }
        }

        async Task IDbRepository.Remove<T>(T entity)
        {
            await Task.Run(() => base.Set<T>().Remove(entity));
        }

        public async Task RemoveRange<T>(IEnumerable<T> entities) where T : class, IEntityBase<T>
        {
            await Task.Run(() => base.Set<T>().RemoveRange(entities));
        }

        async Task IDbRepository.Update<T>(T entity)
        {
            await Task.Run(() => base.Set<T>().Update(entity));
        }

        public async Task UpdateRange<T>(IEnumerable<T> entities) where T : class, IEntityBase<T>
        {
            await Task.Run(() => base.Set<T>().UpdateRange(entities));
        }        

        public IQueryable<T> GetAll<T>() where T : class, IEntityBase<T>
        {
            return base.Set<T>().AsQueryable();
        }

        public void UpdateDate()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is IEntityBase<int> || e.Entity is IEntityBase<string> && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                if (entityEntry.Entity is IEntityBase<int>)
                    ((IEntityBase<int>)entityEntry.Entity).UpdateDate = DateTime.Now;

                if (entityEntry.Entity is IEntityBase<string>)
                    ((IEntityBase<string>)entityEntry.Entity).UpdateDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    if (entityEntry.Entity is IEntityBase<int>)
                        ((IEntityBase<int>)entityEntry.Entity).CreateDate = DateTime.Now;

                    if (entityEntry.Entity is IEntityBase<string>)
                        ((IEntityBase<string>)entityEntry.Entity).CreateDate = DateTime.Now;
                }
            }
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
