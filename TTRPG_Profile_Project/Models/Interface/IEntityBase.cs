using System.ComponentModel.DataAnnotations;

namespace TTRPG_Project.Web.Models.Interface
{
    public interface IEntityBase<TId>
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        [Key]
        public TId Id { get; set; }
        public bool IsActive { get; set; }
        /// <summary>
        /// Дата создания сущности
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Дата обновления сущности
        /// </summary>
        public DateTime DateUpdated { get; set; }
    }
}
