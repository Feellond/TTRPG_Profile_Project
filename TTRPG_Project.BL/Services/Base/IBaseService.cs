using TTRPG_Project.BL.DTO.Filters;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.BL.Services.Base
{
    public interface IBaseService<TEntity, TId> where TEntity: class, IEntityBase<TId>
    {
        Task<bool> Save();
        Task<bool> CreateAsync(TEntity entity);
        Task<ICollection<TEntity>> GetAllAsync();
        Task<bool> EntityExistsAsync(TId id);
        IQueryable<TEntity> GetQuery(BaseFilter<TId, TEntity> filter);
        Task<TEntity?> GetByIdAsync(TId id);
        Task<bool> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        
    }
}
