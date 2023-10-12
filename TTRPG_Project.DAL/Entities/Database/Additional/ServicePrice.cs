using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Additional
{
    /// <summary>
    /// Таблица услуг мира Ведьмака
    /// </summary>
    [Table("ServicePrices")]
    public class ServicePrice : EntityDescriptionBase
    {
        public int Price { get; set; }
    }
}
