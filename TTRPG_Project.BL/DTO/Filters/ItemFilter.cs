using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using LinqKit;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.BL.DTO.Entities.Items;
using System.Linq;
using Microsoft.Identity.Client;

namespace TTRPG_Project.BL.DTO.Filters
{
    public class ItemFilter
    {
        public List<Expression<Func<ItemBaseInfo, bool>>> whereExpression = new List<Expression<Func<ItemBaseInfo, bool>>>();
        public List<Func<IQueryable<ItemBaseInfo>, IIncludableQueryable<ItemBaseInfo, object>>> includeExpression = new();

        public int First { get; set; } = 0;
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 9999;

        public string? Name { get; set; }
        public List<int>? ItemType { get; set; }
        public int? PriceMin { get; set; }
        public int? PriceMax { get; set; }
        public int? SubstanceType { get; set; }
        public bool? ComponentIsAlchemical { get; set; }
        public int? ItemAvailabilityType { get; set; }
        public string? WhereToFind { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum

        public void InitFilter()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Expression<Func<ItemBaseInfo, bool>> filter = entity =>
                    entity.Name.Trim().ToLower().Contains(Name.Trim().ToLower());

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

            if (SubstanceType != null)
            {
                Expression<Func<ItemBaseInfo, bool>> filter = entity =>
                    entity.SubstanceType.Equals(SubstanceType);

                whereExpression.Add(filter);
            }

            if (ComponentIsAlchemical != null && ItemType != null)
            {
                if (ItemType.Contains((int)ItemEntityType.Component))
                {
                    Expression<Func<ItemBaseInfo, bool>> filter = entity =>
                    entity.IsAlchemical.Equals(ComponentIsAlchemical);

                    whereExpression.Add(filter);
                }
            }

            if (ItemAvailabilityType != null)
            {
                Expression<Func<ItemBaseInfo, bool>> filter = entity =>
                    entity.AvailabilityType.Equals(ItemAvailabilityType);

                whereExpression.Add(filter);
            }

            if (!string.IsNullOrEmpty(WhereToFind))
            {
                Expression<Func<ItemBaseInfo, bool>> filter = entity =>
                    entity.WhereToFind.Trim().ToLower().Contains(WhereToFind.Trim().ToLower());

                whereExpression.Add(filter);
            }

            if (PriceMin != null && PriceMax != null)
            {
                Expression<Func<ItemBaseInfo, bool>> filter = entity =>
                    entity.Price >= PriceMin && entity.Price <= PriceMax;

                whereExpression.Add(filter);
            }
        }
    }
}
