using LinqKit;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using TTRPG_Project.BL.DTO.Entities.Creatures;
using TTRPG_Project.BL.DTO.Entities.Items;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Filters
{
    public class CreatureFilter
    {
        public List<Expression<Func<CreatureDTO, bool>>> whereExpression = new List<Expression<Func<CreatureDTO, bool>>>();
        public List<Func<IQueryable<CreatureDTO>, IIncludableQueryable<CreatureDTO, object>>> includeExpression = new();

        public int First { get; set; } = 0;
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 9999;

        public string? Name { get; set; }
        public int? Complexity { get; set; }
        public string? Race { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum

        public void InitFilter()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Expression<Func<CreatureDTO, bool>> filter = entity =>
                    entity.Name.ToLower().Contains(Name.ToLower());

                whereExpression.Add(filter);
            }

            if (Complexity != null)
            {
                Expression<Func<CreatureDTO, bool>> filter = entity =>
                    entity.Complexity.Equals(Complexity);

                whereExpression.Add(filter);
            }

            if (Race != null)
            {
                Expression<Func<CreatureDTO, bool>> filter = entity =>
                    entity.Race.Name.Equals(Race);

                whereExpression.Add(filter);
            }
        }
    }
}
