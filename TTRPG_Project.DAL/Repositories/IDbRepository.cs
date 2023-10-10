using System.Linq.Expressions;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Repositories
{
    public interface IDbRepository
    {
        IQueryable<T> Get<T>(Expression<Func<T, bool>> selector) where T : class, IEntityBase<T>;
        IQueryable<T> Get<T>() where T : class, IEntityBase<T>;
        IQueryable<T> GetAll<T>() where T : class, IEntityBase<T>;

        Task<T> Add<T>(T newEntity) where T : class, IEntityBase<T>;
        Task AddRange<T>(IEnumerable<T> newEntities) where T : class, IEntityBase<T>;

        Task Delete<T>(T entity) where T : class, IEntityBase<T>;

        Task Remove<T>(T entity) where T : class, IEntityBase<T>;
        Task RemoveRange<T>(IEnumerable<T> entities) where T : class, IEntityBase<T>;

        Task Update<T>(T entity) where T : class, IEntityBase<T>;
        Task UpdateRange<T>(IEnumerable<T> entities) where T : class, IEntityBase<T>;

        Task<int> SaveChangesAsync();
    }
}
