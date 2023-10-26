using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Items.Request
{
    public class ComponentRequest : BaseItemDTO
    {
        public List<string> WhereToFind { get; set; } = new List<string>();
        public int Amount { get; set; }
        public int Complexity { get; set; }
        public bool IsAlchemical { get; set; }
        public int SubstanceType { get; set; }
        public List<FormulaComponentListDTO> FormulaComponentLists { get; set; } = new();
        public List<BlueprintComponentListDTO> BlueprintComponentLists { get; set; } = new();
    }
}
