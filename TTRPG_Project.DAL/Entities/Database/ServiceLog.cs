using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Project.DAL.Entities.Database.Base;

namespace TTRPG_Project.DAL.Entities.Database
{
    public class ServiceLog : EntityBase
    {
        public int? EntityId { get; set; }
        public string Title { get; set; }
        public string LogMessage { get; set; }
    }
}
