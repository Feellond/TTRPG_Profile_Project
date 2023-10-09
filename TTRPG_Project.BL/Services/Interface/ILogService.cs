using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Entities.Database;

namespace TTRPG_Project.BL.Services.Interface
{
    public interface ILogService : IBaseService<ServiceLog, int>
    {
    }
}
