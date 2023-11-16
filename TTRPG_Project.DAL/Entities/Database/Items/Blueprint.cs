using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    public class Blueprint : ItemBase//: EntityDescriptionBase
    {
        public int Complexity { get; set; }
        public float TimeSpend { get; set; }
        public int AdditionalPayment { get; set; }
        public List<BlueprintComponentList> BlueprintComponentLists { get; set; } = new();
    }
}
