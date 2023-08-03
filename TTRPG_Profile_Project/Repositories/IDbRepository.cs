using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Project.Web.Models.Interface;

namespace TTRPG_Project.DAL.Repositories
{
    public interface IDbRepository
    {
        IQueryable<T> Get<T>(Expression<Func<T, bool>> selector) where T : class, IEntityBase;
        IQueryable<T> Get<T>() where T : class, IEntityBase;
        IQueryable<T> GetAll<T>() where T : class, IEntityBase;

        Task<Guid> Add<T>(T newEntity) where T : class, IEntityBase;
        Task AddRange<T>(IEnumerable<T> newEntities) where T : class, IEntityBase;

        Task Delete<T>(Guid entity) where T : class, IEntityBase;

        Task Remove<T>(T entity) where T : class, IEntityBase;
        Task RemoveRange<T>(IEnumerable<T> entities) where T : class, IEntityBase;

        Task Update<T>(T entity) where T : class, IEntityBase;
        Task UpdateRange<T>(IEnumerable<T> entities) where T : class, IEntityBase;

        Task<int> SaveChangesAsync();
    }
}
