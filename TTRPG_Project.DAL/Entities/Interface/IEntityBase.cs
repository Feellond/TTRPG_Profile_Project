using System.ComponentModel.DataAnnotations;

namespace TTRPG_Project.DAL.Entities.Interface
{
    public interface IEntityBase
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        [Key]
        public Guid Id { get; set; }
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
