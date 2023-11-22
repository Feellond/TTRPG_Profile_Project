using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Entities.Base;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    /// <summary>
    /// Базовая сущность, которая является связующей с другими таблицами по типу
    /// </summary>
    [Table("ItemBases")]
    public class ItemBase : EntityDescriptionBase
    {
        public int AvailabilityType { get; set; }
        public float Weight { get; set; }
        public int Price { get; set; }
        public List<ItemBaseEffectList> ItemBaseEffectLists { get; set; } = new();
        public List<CreatureRewardList> CreatureRewardLists { get; set; } = new();

        [NotMapped]
        public ItemType ItemType { get; set; }

        /*/// <summary>
        /// Тип таблицы, к которой необходимо обратиться. Реализована через хардкод
        /// </summary>
        /*
            BaseItem = 1,
            AlchemicalItem = 2,
            Tools = 3,
            Armor = 4,
            Weapon = 5,
            Formula = 6,
            Blueprint = 7,
            Component = 8,
        
        public int Type { get; set; }*/


        /*/// <summary>
        /// Id элемента в соответствующей таблице
        /// </summary>
        public int ItemId { get; set; }*/
    }
}
