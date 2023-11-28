using System.ComponentModel.DataAnnotations.Schema;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    public class FormulaSubstanceList
    {
        public int Id { get; set; }
        public int? FormulaId { get; set; }
        public Formula? Formula { get; set; }
        public int SubstanceType { get; set; }
        public int Amount { get; set; } = 1;
    }
}
