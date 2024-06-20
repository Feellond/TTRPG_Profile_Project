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
    public class RaceService : BaseService<Race, int>
    {
        public RaceService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<RaceResponce> GetAllAsync()
        {
            var races = await _dbContext.Races.AsNoTracking()
                .Include(s => s.Source)
                .ToListAsync();

            RaceResponce responce = new()
            {
                Count = races.Count(),
                Entitys = races,
            };

            return responce;
        }

        public async Task<RaceResponce> GetByIdAsync(int id)
        {
            var race = await _dbContext.Races.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .FirstOrDefaultAsync();

            if (race is null)
                throw new CustomException("Существа с таким id не существует");

            RaceResponce responce = new()
            {
                Count = 1,
                Entitys = new List<Race>() { race },
            };

            return responce;
        }

        public async Task<bool> CreateAsync(RaceRequest request)
        {
            Race race = new()
            {
                Description = request.Description,
                Name = request.Name,
                SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
            };

            await _dbContext.Races.AddAsync(race);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(RaceRequest request)
        {
            var race = await _dbContext.Races.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (race is null)
                throw new CustomException("Существо не найдено!");

            race.Description = request.Description;
            race.Name = request.Name;
            race.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            race.UpdateDate = DateTime.Now;

            _dbContext.Entry(race).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var race = await _dbContext.Races.FindAsync(id);
            if (race is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(race);
            return await SaveAsync();
        }
    }
}
