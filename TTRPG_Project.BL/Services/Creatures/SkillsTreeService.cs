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
            var skillsTrees = await _dbContext.SkillsTree.AsNoTracking()
                .Include(s => s.Source)
                .Select(x => new SkillsTreeResponceDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreateDate = x.CreateDate,
                    Description = x.Description,
                    Enabled = x.Enabled,
                    Source = x.Source,
                    SourceId = x.SourceId,
                    UpdateDate = x.UpdateDate,
                    FirstLeftSkillId = x.FirstLeftSkillId,
                    FirstLeftSkillValue = x.FirstLeftSkillValue,
                    FirstMiddleSkillId = x.FirstMiddleSkillId,
                    FirstMiddleSkillValue = x.FirstMiddleSkillValue,
                    FirstRightSkillId = x.FirstRightSkillId,
                    FirstRightSkillValue = x.FirstRightSkillValue,
                    MainSkillId = x.MainSkillId,
                    MainSkillValue = x.MainSkillValue,
                    SecondLeftSkillId = x.SecondLeftSkillId,
                    SecondLeftSkillValue = x.SecondLeftSkillValue,
                    SecondMiddleSkillId = x.SecondMiddleSkillId,
                    SecondMiddleSkillValue = x.SecondMiddleSkillValue,
                    SecondRightSkillId = x.SecondRightSkillId,
                    SecondRightSkillValue = x.SecondRightSkillValue,
                    ThirdLeftSkillId = x.ThirdLeftSkillId,
                    ThirdLeftSkillValue = x.ThirdLeftSkillValue,
                    ThirdMiddleSkillId = x.ThirdMiddleSkillId,
                    ThirdMiddleSkillValue = x.ThirdMiddleSkillValue,
                    ThirdRightSkillId = x.ThirdRightSkillId,
                    ThirdRightSkillValue = x.ThirdRightSkillValue,
                })
                .ToListAsync();

            foreach(var tree in skillsTrees)
            {
                tree.MainSkill = await _dbContext.Skills.Where(x => x.Id == tree.MainSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

                tree.FirstLeftSkill = await _dbContext.Skills.Where(x => x.Id == tree.FirstLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                tree.SecondLeftSkill = await _dbContext.Skills.Where(x => x.Id == tree.SecondLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                tree.ThirdLeftSkill = await _dbContext.Skills.Where(x => x.Id == tree.ThirdLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

                tree.FirstMiddleSkill = await _dbContext.Skills.Where(x => x.Id == tree.FirstMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                tree.SecondMiddleSkill = await _dbContext.Skills.Where(x => x.Id == tree.SecondMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                tree.ThirdMiddleSkill = await _dbContext.Skills.Where(x => x.Id == tree.ThirdMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

                tree.FirstRightSkill = await _dbContext.Skills.Where(x => x.Id == tree.FirstRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                tree.SecondRightSkill = await _dbContext.Skills.Where(x => x.Id == tree.SecondRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                tree.ThirdRightSkill = await _dbContext.Skills.Where(x => x.Id == tree.ThirdRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            }

            SkillsTreeResponce responce = new()
            {
                Count = skillsTrees.Count(),
                SkillsTrees = skillsTrees,
            };

            return responce;
        }

        public async Task<SkillsTreeResponce> GetByIdAsync(int id)
        {           
            var skillsTree = await _dbContext.SkillsTree.AsNoTracking()
               .Where(x => x.Id == id)
               .Include(s => s.Source)
               .Select(x => new SkillsTreeResponceDTO
               {
                   Id = x.Id,
                   Name = x.Name,
                   CreateDate = x.CreateDate,
                   Description = x.Description,
                   Enabled = x.Enabled,
                   Source = x.Source,
                   SourceId = x.SourceId,
                   UpdateDate = x.UpdateDate,

                   LeftBranchName = x.LeftBranchName,
                   MiddleBranchName = x.MiddleBranchName,
                   RightBranchName = x.RightBranchName,

                   FirstLeftSkillId = x.FirstLeftSkillId,
                   FirstLeftSkillValue = x.FirstLeftSkillValue,
                   FirstMiddleSkillId = x.FirstMiddleSkillId,
                   FirstMiddleSkillValue = x.FirstMiddleSkillValue,
                   FirstRightSkillId = x.FirstRightSkillId,
                   FirstRightSkillValue = x.FirstRightSkillValue,
                   MainSkillId = x.MainSkillId,
                   MainSkillValue = x.MainSkillValue,
                   SecondLeftSkillId = x.SecondLeftSkillId,
                   SecondLeftSkillValue = x.SecondLeftSkillValue,
                   SecondMiddleSkillId = x.SecondMiddleSkillId,
                   SecondMiddleSkillValue = x.SecondMiddleSkillValue,
                   SecondRightSkillId = x.SecondRightSkillId,
                   SecondRightSkillValue = x.SecondRightSkillValue,
                   ThirdLeftSkillId = x.ThirdLeftSkillId,
                   ThirdLeftSkillValue = x.ThirdLeftSkillValue,
                   ThirdMiddleSkillId = x.ThirdMiddleSkillId,
                   ThirdMiddleSkillValue = x.ThirdMiddleSkillValue,
                   ThirdRightSkillId = x.ThirdRightSkillId,
                   ThirdRightSkillValue = x.ThirdRightSkillValue,
               })
               .FirstOrDefaultAsync();

            if (skillsTree is null)
                throw new CustomException("Дерева талантов с таким id не существует");

            skillsTree.MainSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.MainSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

            skillsTree.FirstLeftSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.FirstLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            skillsTree.SecondLeftSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.SecondLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            skillsTree.ThirdLeftSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.ThirdLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

            skillsTree.FirstMiddleSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.FirstMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            skillsTree.SecondMiddleSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.SecondMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            skillsTree.ThirdMiddleSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.ThirdMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

            skillsTree.FirstRightSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.FirstRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            skillsTree.SecondRightSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.SecondRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            skillsTree.ThirdRightSkill = await _dbContext.Skills.Where(x => x.Id == skillsTree.ThirdRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

            SkillsTreeResponce responce = new()
            {
                Count = 1,
                SkillsTrees = new List<SkillsTreeResponceDTO>() { skillsTree },
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
                SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
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
            skillsTree.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
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
