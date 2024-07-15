using Microsoft.EntityFrameworkCore.Query;
using System.Data.SqlClient;
using System.Linq.Expressions;
using TTRPG_Project.BL.DTO.Entities.Creatures;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Filters
{
    public class RaceFilter
    {
        public List<Expression<Func<Race, bool>>> whereExpression = new List<Expression<Func<Race, bool>>>();
        public List<Func<IQueryable<Race>, IIncludableQueryable<Race, object>>> includeExpression = new();

        public int First { get; set; } = 0;
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 9999;

        public string? Name { get; set; }
        public bool? OnlyPlayable { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum

        public void InitFilter()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Expression<Func<Race, bool>> filter = entity =>
                    entity.Name.Trim().ToLower().Contains(Name.Trim().ToLower());

                whereExpression.Add(filter);
            }

            if (OnlyPlayable != null)
            {
                Expression<Func<Race, bool>> filter = entity =>
                    entity.IsPlayable.Equals(OnlyPlayable);

                whereExpression.Add(filter);
            }
        }
    }
}
