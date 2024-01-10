using IdentityModel;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;
using TTRPG_Project.BL.DTO.Entities.Items.Responce;
using LinqKit;
using TTRPG_Project.DAL.Const;

namespace TTRPG_Project.BL.DTO.Filters
{
    public class ItemFilter
    {
        public List<Expression<Func<ItemBaseResponce, bool>>> whereExpression = new List<Expression<Func<ItemBaseResponce, bool>>>();
        public List<Func<IQueryable<ItemBaseResponce>, IIncludableQueryable<ItemBaseResponce, object>>> includeExpression = new();

        public string? Name { get; set; }
        public List<int>? ItemType { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum

        public void InitFilter()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Expression<Func<ItemBaseResponce, bool>> filter = entity =>
                    entity.Name.ToLower().Contains(Name.ToLower());

                whereExpression.Add(filter);
            }

            if (ItemType != null)
                if (ItemType.Count > 0)
                {
                    var typeFilters = ItemType.Select(type =>
                        PredicateBuilder.New<ItemBaseResponce>(entity => entity.ItemType == type)).ToList();

                    Expression<Func<ItemBaseResponce, bool>> finalTypeFilter = typeFilters.Aggregate((current, next) => current.Or(next));

                    whereExpression.Add(finalTypeFilter);
                }
        }
    }
}
