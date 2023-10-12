using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Spells
{
    [Table("SpellComponentList")]
    public class SpellComponentList : EntityBase
    {
        public int SpellId { get; set; }
        /// <summary>
        /// Компонент берется из ItemBase с Type = 8
        /// </summary>
        public int ComponentId { get; set; }
        public int Amount { get; set; }
    }
}
