using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Items.Request
{
    public class FormulaRequest : BaseItemDTO
    {
        public int Complexity { get; set; }
        public float TimeSpend { get; set; }
        public int AdditionalPayment { get; set; }
        public List<FormulaSubstanceListDTO>? FormulaSubstanceList { get; set; } = new();
    }
}
