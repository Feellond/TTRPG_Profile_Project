using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Additional
{
    /// <summary>
    /// Таблица услуг мира Ведьмака
    /// </summary>
    public class ServicePrice : EntityDescriptionBase
    {
        public int Price { get; set; }
    }
}
