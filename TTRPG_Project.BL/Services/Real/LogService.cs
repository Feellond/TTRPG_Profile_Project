using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TTRPG_Project.BL.DTO.Logs;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.BL.Services.Interface;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database;
using static System.Net.Mime.MediaTypeNames;

namespace TTRPG_Project.BL.Services.Real
{
    public class LogService : BaseService<ServiceLog, int>, ILogService
    {
        public LogService(ApplicationDbContext dbContext) : base(dbContext)
        {
            //_db = db;
        }

        public async Task AddError(string logMessage)
        {
            var logError = new ServiceLog
            {
                EntityId = 0,
                Title = "Back",
                LogMessage = logMessage,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };

            _dbContext.ServiceLogs.Add(logError);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<LogResponse> GetLogsAsync(int entityId, int page) // entityId - 0 - back 1 - front
        {

            int pageSize = 30;

            var logs = await _dbContext.ServiceLogs.Where(it => it.EntityId == entityId)
                                            .OrderByDescending(it => it.CreateDate)
                                            .Skip((page - 1) * pageSize)
                                            .Take(pageSize)
                                            .ToListAsync();

            var totalPages = ((await _dbContext.ServiceLogs.CountAsync(it => it.EntityId == entityId)) / pageSize) + 1;


            return new LogResponse { Logs = logs, TotalPages = totalPages };
        }

        public async Task<ServiceLog> AddFrontLogAsync(LogRequest logInfo)
        {
            var log = new ServiceLog
            {
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                EntityId = 1,
                Title = "Front: " + logInfo.Title,
                LogMessage = logInfo.Message,
            };

            _dbContext.ServiceLogs.Add(log);
            await _dbContext.SaveChangesAsync();
            return log;
        }

        public override async Task<ICollection<ServiceLog>> GetAllAsync()
        {
            return await _dbContext.ServiceLogs.ToListAsync();
        }

        public async override Task<ServiceLog?> GetByIdAsync(int id)
        {
            return await _dbContext.ServiceLogs.SingleOrDefaultAsync();
        }
    }
}
