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
    public class SkillsTreeService : BaseService<SkillsTree, int>
    {
        public SkillsTreeService(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }

        public async Task<SkillsTreeResponce> GetAllAsync()
        {
            var skillsTrees = await _dbContext.SkillsTree.AsNoTracking().ToListAsync();

            SkillsTreeResponce responce = new()
            {
                Count = skillsTrees.Count(),
                SkillsTrees = skillsTrees,
            };

            return responce;
        }

        public async Task<SkillsTreeResponce> GetByIdAsync(int id)
        {
            var skillsTree = await _dbContext.SkillsTree.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();

            if (skillsTree is null)
                throw new CustomException("Существа с таким id не существует");

            SkillsTreeResponce responce = new()
            {
                Count = 1,
                SkillsTrees = new List<SkillsTree>() { skillsTree },
            };

            return responce;
        }

        public async Task<bool> CreateAsync(SkillsTreeRequest request)
        {
            SkillsTree skillsTree = new()
            {
                Description = request.Description,
                FirstLeftSkillId = request.FirstLeftSkillId,
                FirstLeftSkillValue = request.FirstLeftSkillValue,
                FirstMiddleSkillId = request.FirstMiddleSkillId,
                FirstMiddleSkillValue = request.FirstMiddleSkillValue,
                FirstRightSkillId = request.FirstRightSkillId,
                FirstRightSkillValue = request.FirstRightSkillValue,
                MainSkillId = request.MainSkillId,
                MainSkillValue = request.MainSkillValue,
                SecondLeftSkillId = request.SecondLeftSkillId,
                SecondLeftSkillValue = request.SecondLeftSkillValue,
                SecondMiddleSkillId = request.SecondMiddleSkillId,
                SecondMiddleSkillValue = request.SecondMiddleSkillValue,
                SecondRightSkillId = request.SecondRightSkillId,
                SecondRightSkillValue = request.SecondRightSkillValue,
                ThirdLeftSkillId = request.ThirdLeftSkillId,
                ThirdLeftSkillValue = request.ThirdLeftSkillValue,
                ThirdMiddleSkillId = request.ThirdMiddleSkillId,
                ThirdMiddleSkillValue = request.ThirdMiddleSkillValue,
                ThirdRightSkillId = request.ThirdRightSkillId,
                ThirdRightSkillValue = request.ThirdRightSkillValue,
                Name = request.Name,
                SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2,
            };

            await _dbContext.SkillsTree.AddAsync(skillsTree);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(SkillsTreeRequest request)
        {
            var skillsTree = await _dbContext.SkillsTree.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (skillsTree is null)
                throw new CustomException("Существо не найдено!");

            skillsTree.Description = request.Description;
            skillsTree.FirstLeftSkillId = request.FirstLeftSkillId;
            skillsTree.FirstLeftSkillValue = request.FirstLeftSkillValue;
            skillsTree.FirstMiddleSkillId = request.FirstMiddleSkillId;
            skillsTree.FirstMiddleSkillValue = request.FirstMiddleSkillValue;
            skillsTree.FirstRightSkillId = request.FirstRightSkillId;
            skillsTree.FirstRightSkillValue = request.FirstRightSkillValue;
            skillsTree.MainSkillId = request.MainSkillId;
            skillsTree.MainSkillValue = request.MainSkillValue;
            skillsTree.SecondLeftSkillId = request.SecondLeftSkillId;
            skillsTree.SecondLeftSkillValue = request.SecondLeftSkillValue;
            skillsTree.SecondMiddleSkillId = request.SecondMiddleSkillId;
            skillsTree.SecondMiddleSkillValue = request.SecondMiddleSkillValue;
            skillsTree.SecondRightSkillId = request.SecondRightSkillId;
            skillsTree.SecondRightSkillValue = request.SecondRightSkillValue;
            skillsTree.ThirdLeftSkillId = request.ThirdLeftSkillId;
            skillsTree.ThirdLeftSkillValue = request.ThirdLeftSkillValue;
            skillsTree.ThirdMiddleSkillId = request.ThirdMiddleSkillId;
            skillsTree.ThirdMiddleSkillValue = request.ThirdMiddleSkillValue;
            skillsTree.ThirdRightSkillId = request.ThirdRightSkillId;
            skillsTree.ThirdRightSkillValue = request.ThirdRightSkillValue;
            skillsTree.Name = request.Name;
            skillsTree.SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2;
            skillsTree.UpdateDate = DateTime.Now;


            _dbContext.Entry(skillsTree).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var skillsTree = await _dbContext.SkillsTree.FindAsync(id);
            if (skillsTree is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(skillsTree);
            return await SaveAsync();
        }
    }
}
