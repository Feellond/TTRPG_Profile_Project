using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System.Linq.Expressions;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.BL.DTO.Filters
{
    public class BaseFilter<T, TEntity> where TEntity : class, IEntityBase<T>
    {
        public List<Expression<Func<TEntity, bool>>> whereExpression = new List<Expression<Func<TEntity, bool>>>();
        public List<Expression<Func<TEntity, object>>> includeExpression = new List<Expression<Func<TEntity, object>>>();
        public Expression<Func<TEntity, object>> orderExpression { get; set; }

        public T? Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum


        public virtual void InitFilter()
        {
            if (!EqualityComparer<T>.Default.Equals(Id, default(T)))
            {
                Expression<Func<TEntity, bool>> filter = entity => entity.Id.Equals(Id);
                whereExpression.Add(filter);
            }

            if (CreateDate != null)
            {
                Expression<Func<TEntity, bool>> filter = entity => entity.CreateDate.Date == CreateDate.Value.Date;
                whereExpression.Add(filter);
            }

            if (UpdateDate != null)
            {
                Expression<Func<TEntity, bool>> filter = entity => entity.UpdateDate.Date == UpdateDate.Value.Date;
                whereExpression.Add(filter);
            }
        }
    }
}
