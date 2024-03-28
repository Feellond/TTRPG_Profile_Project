using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Spells;

namespace TTRPG_Project.BL.DTO.Filters
{
    public class SpellFilter
    {
        public List<Expression<Func<Spell, bool>>> whereExpression = new List<Expression<Func<Spell, bool>>>();
        public List<Func<IQueryable<Spell>, IIncludableQueryable<Spell, object>>> includeExpression = new();

        public int First { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public string? Name { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum

        public void InitFilter()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Expression<Func<Spell, bool>> filter = entity =>
                    entity.Name.ToLower().Contains(Name.ToLower());

                whereExpression.Add(filter);
            }
        }
    }
}
