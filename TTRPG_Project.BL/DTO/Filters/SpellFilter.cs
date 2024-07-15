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

        public int First { get; set; } = 0;
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 9999;

        public string? Name { get; set; }
        public int? SpellLevel { get; set; }
        public int? SpellType { get; set; }
        public int? SourceType { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum

        public void InitFilter()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Expression<Func<Spell, bool>> filter = entity =>
                    entity.Name.Trim().ToLower().Contains(Name.Trim().ToLower());

                whereExpression.Add(filter);
            }

            if (SpellLevel != null)
            {
                Expression<Func<Spell, bool>> filter = entity =>
                    entity.SpellLevel.Equals(SpellLevel);

                whereExpression.Add(filter);
            }

            if (SpellType != null)
            {
                Expression<Func<Spell, bool>> filter = entity =>
                    entity.SpellType.Equals(SpellType);

                whereExpression.Add(filter);
            }

            if (SourceType != null)
            {
                Expression<Func<Spell, bool>> filter = entity =>
                    entity.SourceType.Equals(SourceType);

                whereExpression.Add(filter);
            }

        }
    }
}
