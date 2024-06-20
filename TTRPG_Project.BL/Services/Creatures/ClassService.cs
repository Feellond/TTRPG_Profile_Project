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
    public class ClassService : BaseService<Class, int>
    {
        public ClassService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<ClassResponce> GetAllAsync()
        {
            var classes = await _dbContext.Classes.AsNoTracking()
                .Include(s => s.Source)
                .Include(s => s.SkillsTree)
                .ToListAsync();

            ClassResponce responce = new()
            {
                Count = classes.Count(),
                Entitys = classes,
            };

            return responce;
        }

        public async Task<ClassResponce> GetByIdAsync(int id)
        {
            var singleClass = await _dbContext.Classes.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .FirstOrDefaultAsync();

            if (singleClass is null)
                throw new CustomException("Существа с таким id не существует");

            ClassResponce responce = new()
            {
                Count = 1,
                Entitys = new List<Class>() { singleClass },
            };

            return responce;
        }

        public async Task<bool> CreateAsync(ClassRequest request)
        {
            Class singleClass = new()
            {
                DefaultMagicAbilities = request.DefaultMagicAbilities,
                Description = request.Description,
                Energy = request.Energy,
                Name = request.Name,
                SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
            };

            await _dbContext.Classes.AddAsync(singleClass);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(ClassRequest request)
        {
            var singleClass = await _dbContext.Classes.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (singleClass is null)
                throw new CustomException("Существо не найдено!");

            singleClass.DefaultMagicAbilities = request.DefaultMagicAbilities;
            singleClass.Description = request.Description;
            singleClass.Energy = request.Energy;
            singleClass.Name = request.Name;
            singleClass.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            singleClass.UpdateDate = DateTime.Now;

            _dbContext.Entry(singleClass).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var singleClass = await _dbContext.Classes.FindAsync(id);
            if (singleClass is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(singleClass);
            return await SaveAsync();
        }
    }
}
