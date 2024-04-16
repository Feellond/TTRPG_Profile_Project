using AutoMapper;
using Azure;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TTRPG_Project.BL.DTO.Creatures.Request;
using TTRPG_Project.BL.DTO.Entities.Creatures.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.DTO.Filters;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.Services.Creatures
{
    public class AbilityService : BaseService<Ability, int>
    {
        public AbilityService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<AbilityResponce> GetAllAsync()
        {
            var abilitiys = await _dbContext.Abilitiys.AsNoTracking()
                .Include(s => s.Source)
                .Include(r => r.Race)
                .ToListAsync();

            AbilityResponce responce = new()
            {
                Count = abilitiys.Count(),
                Abilities = abilitiys,
            };

            return responce;
        }

        public async Task<AbilityResponce> GetByIdAsync(int id)
        {
            var abilitiy = await _dbContext.Abilitiys.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(r => r.Race)
                .FirstOrDefaultAsync();

            if (abilitiy is null)
                throw new CustomException("Существа с таким id не существует");

            AbilityResponce responce = new()
            {
                Count = 1,
                Abilities = new List<Ability>() { abilitiy },
            };

            return responce;
        }

        public async Task<bool> CreateAsync(AbilitiyRequest request)
        {
            Ability ability = new()
            {
                Description = request.Description,
                Name = request.Name,
                RaceId = request.RaceId ?? request.Race?.Id,
                SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
                Type = request.Type,
            };

            await _dbContext.Abilitiys.AddAsync(ability);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(AbilitiyRequest request)
        {
            var abilitiy = await _dbContext.Abilitiys.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (abilitiy is null)
                throw new CustomException("Существо не найдено!");

            abilitiy.Description = request.Description;
            abilitiy.Name = request.Name;
            abilitiy.RaceId = request.RaceId ?? request.Race?.Id;
            abilitiy.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            abilitiy.Type = request.Type;
            abilitiy.UpdateDate = DateTime.Now;

            _dbContext.Entry(abilitiy).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var abilitiy = await _dbContext.Abilitiys.FindAsync(id);
            if (abilitiy is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(abilitiy);
            return await SaveAsync();
        }
    }
}
