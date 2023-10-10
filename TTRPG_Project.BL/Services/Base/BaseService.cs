using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TTRPG_Project.BL.DTO.Filters;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.BL.Services.Base
{
    public abstract class BaseService<TEntity, TId> : IBaseService<TEntity, TId> where TEntity : class, IEntityBase<TId>
    {
        protected readonly ApplicationDbContext _dbContext;

        public BaseService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // У этих методов нет реализации, так как у дочернего класса будет 
        // своя реализация в зависимости от связей с которыми нужно получить сущность (Include)
        public abstract Task<ICollection<TEntity>> GetAllAsync();
        public abstract Task<TEntity?> GetByIdAsync(TId id);       

        public async Task<bool> EntityExistsAsync(TId id)
        {
            var foundEntity = await _dbContext.FindAsync<TEntity>(id);
            return foundEntity != null;
        }

        public virtual async Task<bool> CreateAsync(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            return await Save();
        }
        public virtual async Task<bool> DeleteAsync(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            return await Save();
        }             

        public async Task<bool> Save()
        {
            var saved = await _dbContext.SaveChangesAsync();
            return saved > 0 ? true : false;
        }

        public virtual async Task<bool> UpdateAsync(TEntity entity)
        {
            var saved = _dbContext.Update(entity);
            return await Save();
        }

        public IQueryable<TEntity> GetQuery(BaseFilter<TId, TEntity> filter)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();
            //
            foreach (var item in filter.whereExpression)
            {
                query = query.Where(item);
            }

            //
            foreach (var includeProperty in filter.includeExpression)
            {
                query = query.Include(includeProperty);
            }


            //
            if (filter.orderExpression != null)
            {
                if (filter.Order == SortOrder.Ascending)
                {
                    query = query.OrderBy(filter.orderExpression);
                }
                else
                {
                    query = query.OrderByDescending(filter.orderExpression);
                }
            }


            return query;
        }
    }
}
