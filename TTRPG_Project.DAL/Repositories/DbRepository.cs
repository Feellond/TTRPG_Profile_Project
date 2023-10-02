using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Repositories
{
    public class DbRepository : IDbRepository
    {
        private readonly ApplicationDbContext _context;

        public DbRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Get<T>() where T : class, IEntityBase<T>
        {
            return _context.Set<T>().Where(x => x.IsActive).AsQueryable();
        }

        public IQueryable<T> Get<T>(Expression<Func<T, bool>> selector) where T : class, IEntityBase<T>
        {
            return _context.Set<T>().Where(selector).Where(x => x.IsActive).AsQueryable();
        }

        public async Task<T> Add<T>(T newEntity) where T : class, IEntityBase<T>
        {
            var entity = await _context.Set<T>().AddAsync(newEntity);
            return entity.Entity.Id;
        }

        public async Task AddRange<T>(IEnumerable<T> newEntities) where T : class, IEntityBase<T>
        {
            await _context.Set<T>().AddRangeAsync(newEntities);
        }

        public async Task Delete<T>(T id) where T : class, IEntityBase<T>
        {
            var activeEntity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            activeEntity.IsActive = false;
            await Task.Run(() => _context.Update(activeEntity));
        }

        public async Task Remove<T>(T entity) where T : class, IEntityBase<T>
        {
            await Task.Run(() => _context.Set<T>().Remove(entity));
        }

        public async Task RemoveRange<T>(IEnumerable<T> entities) where T : class, IEntityBase<T>
        {
            await Task.Run(() => _context.Set<T>().RemoveRange(entities));
        }

        public async Task Update<T>(T entity) where T : class, IEntityBase<T>
        {
            await Task.Run(() => _context.Set<T>().Update(entity));
        }

        public async Task UpdateRange<T>(IEnumerable<T> entities) where T : class, IEntityBase<T>
        {
            await Task.Run(() => _context.Set<T>().UpdateRange(entities));
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public IQueryable<T> GetAll<T>() where T : class, IEntityBase<T>
        {
            return _context.Set<T>().AsQueryable();
        }
    }
}
