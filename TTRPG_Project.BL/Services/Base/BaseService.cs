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

        /// <summary>
        /// Получение всех элементов
        /// </summary>
        /// <returns>Коллекция элементов</returns>
        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            var list = await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
            return list;
        }

        /// <summary>
        /// Получение элемента по его Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TEntity?> GetByIdAsync(TId id)
        {
            var foundEntity = await _dbContext.FindAsync<TEntity>(id);
            return foundEntity;
        }   

        /// <summary>
        /// Проверка, существует ли элемент по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> EntityExistsAsync(TId id)
        {
            var foundEntity = await _dbContext.FindAsync<TEntity>(id);
            return foundEntity != null;
        }

        /// <summary>
        /// Создание нового элемента в БД
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<bool> CreateAsync(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            return await SaveAsync();
        }

        /// <summary>
        /// Удаление элемента из БД
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<bool> DeleteAsync(TEntity entity)
        {
            _dbContext.Remove(entity);
            return await SaveAsync();
        }

        /// <summary>
        /// Сохранение изменений БД
        /// </summary>
        /// <returns></returns>
        public async Task<bool> SaveAsync()
        {
            var saved = await _dbContext.SaveChangesAsync();
            return saved > 0 ? true : false;
        }

        /// <summary>
        /// Изменение элемента в БД
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual async Task<bool> UpdateAsync(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            var saved = _dbContext.Update(entity);
            return await SaveAsync();
        }

        /// <summary>
        /// Получение отфильтрованной очереди из БД
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
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
