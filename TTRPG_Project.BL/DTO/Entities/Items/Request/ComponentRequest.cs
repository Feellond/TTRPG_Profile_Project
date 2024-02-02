using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Items.Request
{
    public class ComponentRequest : BaseItemDTO
    {
        public string WhereToFind { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
        public int Complexity { get; set; }
        public bool IsAlchemical { get; set; }
        public int SubstanceType { get; set; }
        public List<FormulaSubstanceListDTO> FormulaSubstanceList { get; set; } = new();
        public List<BlueprintComponentListDTO> BlueprintComponentList { get; set; } = new();
    }
}
