using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.DAL.Entities.Database.Spells
{
    [Table("SpellComponentList")]
    public class SpellComponentList
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public Spell Spell { get; set; }
        /// <summary>
        /// Компонент берется из ItemBase с Type = 8
        /// </summary>
        public int ComponentId { get; set; }
        public Component Component { get; set; }
        public int Amount { get; set; }
    }
}
