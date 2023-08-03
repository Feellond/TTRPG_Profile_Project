using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Entities.Database
{
    public class EntityBase : IEntityBase
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; }
    }
}
