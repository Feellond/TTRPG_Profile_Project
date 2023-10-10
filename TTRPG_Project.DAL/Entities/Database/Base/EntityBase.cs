using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Entities.Database.Base
{
    public class EntityBase : IEntityBase<int>
    {
        public int Id { get; set; }
        public bool Enabled { get; set; } = true;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; }
    }
}
