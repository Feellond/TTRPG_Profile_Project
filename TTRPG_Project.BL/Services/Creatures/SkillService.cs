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
    public class SkillService : BaseService<Skill, int>
    {
        public SkillService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<SkillResponce> GetAllAsync()
        {
            var skills = await _dbContext.Skills.AsNoTracking()
                .Include(s => s.Source)
                .Include(s => s.Stat)
                .ToListAsync();

            SkillResponce responce = new()
            {
                Count = skills.Count(),
                Skills = skills,
            };

            return responce;
        }

        public async Task<SkillResponce> GetByIdAsync(int id)
        {
            var skill = await _dbContext.Skills.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(s => s.Stat)
                .FirstOrDefaultAsync();

            if (skill is null)
                throw new CustomException("Существа с таким id не существует");

            SkillResponce responce = new()
            {
                Count = 1,
                Skills = new List<Skill>() { skill },
            };

            return responce;
        }

        public async Task<bool> CreateAsync(SkillRequest request)
        {
            Skill skill = new()
            {
                Description = request.Description,
                IsClassSkill = request.IsClassSkill,
                IsDifficult = request.IsDifficult,
                Name = request.Name,
                SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2,
                StatId = request.StatId ?? request.Stat?.Id,                
            };

            await _dbContext.Skills.AddAsync(skill);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(SkillRequest request)
        {
            var skill = await _dbContext.Skills.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (skill is null)
                throw new CustomException("Существо не найдено!");

            skill.Description = request.Description;
            skill.IsClassSkill = request.IsClassSkill;
            skill.IsDifficult = request.IsDifficult;
            skill.Name = request.Name;
            skill.SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2;
            skill.StatId = request.StatId ?? request.Stat?.Id;
            skill.UpdateDate = DateTime.Now;

            _dbContext.Entry(skill).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var skill = await _dbContext.Skills.FindAsync(id);
            if (skill is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(skill);
            return await SaveAsync();
        }
    }
}
