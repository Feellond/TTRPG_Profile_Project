using AutoMapper;
using Azure;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TTRPG_Project.BL.DTO.Creatures.Request;
using TTRPG_Project.BL.DTO.Entities.Creatures.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.Services.Creatures
{
    public class StatService : BaseService<Stat, int>
    {
        public StatService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<StatResponce> GetAllAsync()
        {
            var stats = await _dbContext.Stats.AsNoTracking().ToListAsync();

            StatResponce responce = new()
            {
                Count = stats.Count(),
                Stats = stats,
            };

            return responce;
        }

        public async Task<StatResponce> GetByIdAsync(int id)
        {
            var stat = await _dbContext.Stats.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();

            if (stat is null)
                throw new CustomException("Существа с таким id не существует");

            StatResponce responce = new()
            {
                Count = 1,
                Stats = new List<Stat>() { stat },
            };

            return responce;
        }

        public async Task<bool> CreateAsync(StatRequest request)
        {
            Stat stat = new()
            {
                Description = request.Description,
                Name = request.Name,
                SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
            };

            await _dbContext.Stats.AddAsync(stat);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(StatRequest request)
        {
            var stat = await _dbContext.Stats.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (stat is null)
                throw new CustomException("Существо не найдено!");

            stat.Description = request.Description;
            stat.Name = request.Name;
            stat.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            stat.UpdateDate = DateTime.Now;

            _dbContext.Entry(stat).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var stat = await _dbContext.Stats.FindAsync(id);
            if (stat is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(stat);
            return await SaveAsync();
        }
    }
}
