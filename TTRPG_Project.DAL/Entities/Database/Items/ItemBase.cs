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
        public int AvailabilityType { get; set; } = (int)ItemAvailabilityType.None;
        public double Weight { get; set; } = 0;
        public int Price { get; set; } = 0;
        public List<ItemBaseEffectList> ItemBaseEffectList { get; set; } = new();
        public List<CreatureReward> CreatureReward { get; set; } = new();

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
