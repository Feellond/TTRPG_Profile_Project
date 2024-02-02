using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Items
{
    public class FormulaSubstanceListDTO
    {
        public int? Id { get; set; }
        public int? FormulaId { get; set; }
        public Formula? Formula { get; set; }
        public int SubstanceType { get; set; }
        public int Amount { get; set; }
    }
}
