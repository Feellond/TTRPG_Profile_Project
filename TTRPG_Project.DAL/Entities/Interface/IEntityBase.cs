using System.ComponentModel.DataAnnotations;

namespace TTRPG_Project.DAL.Entities.Interface
{
    public interface IEntityBase<TId>
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        [Key]
        public TId Id { get; set; }
        public bool Enabled { get; set; }
        /// <summary>
        /// Дата создания сущности
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Дата обновления сущности
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}
