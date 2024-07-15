using Microsoft.EntityFrameworkCore.Query;
using System.Data.SqlClient;
using System.Linq.Expressions;
using TTRPG_Project.BL.DTO.Entities.Creatures;
using TTRPG_Project.BL.DTO.Entities.Creatures.Responce;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Filters
{
    public class ClassFilter
    {
        public List<Expression<Func<ClassResponceDTO, bool>>> whereExpression = new List<Expression<Func<ClassResponceDTO, bool>>>();
        public List<Func<IQueryable<ClassResponceDTO>, IIncludableQueryable<ClassResponceDTO, object>>> includeExpression = new();

        public int First { get; set; } = 0;
        public int Page { get; set; } = 0;
        public int PageSize { get; set; } = 9999;

        public string? Name { get; set; }
        public SortOrder Order { get; set; } = SortOrder.Descending; //Enum

        public void InitFilter()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                Expression<Func<ClassResponceDTO, bool>> filter = entity =>
                    entity.Name.ToLower().Contains(Name.Trim().ToLower());

                whereExpression.Add(filter);
            }
        }
    }
}
