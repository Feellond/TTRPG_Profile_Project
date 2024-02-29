using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using LinqKit;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.BL.DTO.Entities.Items;

namespace TTRPG_Project.BL.DTO.Filters
{
    public class ItemFilter
    {
        public List<Expression<Func<ItemBaseInfo, bool>>> whereExpression = new List<Expression<Func<ItemBaseInfo, bool>>>();
        public List<Func<IQueryable<ItemBaseInfo>, IIncludableQueryable<ItemBaseInfo, object>>> includeExpression = new();

        public int First { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public string? Name { get; set; }
        public List<int>? ItemType { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum

        public void InitFilter()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Expression<Func<ItemBaseInfo, bool>> filter = entity =>
                    entity.Name.ToLower().Contains(Name.ToLower());

                whereExpression.Add(filter);
            }

            if (ItemType != null)
                if (ItemType.Count > 0)
                {
                    var typeFilters = ItemType.Select(type =>
                        PredicateBuilder.New<ItemBaseInfo>(entity => entity.ItemType == type)).ToList();

                    Expression<Func<ItemBaseInfo, bool>> finalTypeFilter = typeFilters.Aggregate((current, next) => current.Or(next));

                    whereExpression.Add(finalTypeFilter);
                }
        }
    }
}
