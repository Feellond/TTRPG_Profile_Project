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

        public int First { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public string? Name { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum

        public void InitFilter()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Expression<Func<CreatureDTO, bool>> filter = entity =>
                    entity.Name.ToLower().Contains(Name.ToLower());

                whereExpression.Add(filter);
            }
        }
    }
}
