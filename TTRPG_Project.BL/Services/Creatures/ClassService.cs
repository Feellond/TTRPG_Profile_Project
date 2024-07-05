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
                    .ThenInclude(s => s.Source)
                    .Select(x => new ClassResponceDTO
                    {
                        Id = x.Id,
                        CreateDate = x.CreateDate,
                        DefaultMagicAbilities = x.DefaultMagicAbilities,
                        Description = x.Description,
                        Enabled = x.Enabled,
                        Energy = x.Energy,
                        Name = x.Name,
                        //SkillsTree = x.SkillsTree,
                        SkillsTreeId = x.SkillsTreeId,
                        Source = x.Source,
                        SourceId = x.SourceId,
                        UpdateDate = x.UpdateDate,
                    })
                    .ToListAsync();

            foreach (var clazz in classes)
            {
                var skillTree = await _dbContext.SkillsTree
                    .Where(x => x.Id == clazz.SkillsTreeId)
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
                    }).FirstOrDefaultAsync();

                clazz.SkillsTree = skillTree;

                if (clazz.SkillsTree is null)
                    continue;

                clazz.SkillsTree.MainSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.MainSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

                clazz.SkillsTree.FirstLeftSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.FirstLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                clazz.SkillsTree.SecondLeftSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.SecondLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                clazz.SkillsTree.ThirdLeftSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.ThirdLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

                clazz.SkillsTree.FirstMiddleSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.FirstMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                clazz.SkillsTree.SecondMiddleSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.SecondMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                clazz.SkillsTree.ThirdMiddleSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.ThirdMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

                clazz.SkillsTree.FirstRightSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.FirstRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                clazz.SkillsTree.SecondRightSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.SecondRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
                clazz.SkillsTree.ThirdRightSkill = await _dbContext.Skills.Where(x => x.Id == clazz.SkillsTree.ThirdRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            }

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
                .Include(s => s.SkillsTree)
                    .ThenInclude(s => s.Source)
                    .Select(x => new ClassResponceDTO
                    {
                        Id = x.Id,
                        CreateDate = x.CreateDate,
                        DefaultMagicAbilities = x.DefaultMagicAbilities,
                        Description = x.Description,
                        Enabled = x.Enabled,
                        Energy = x.Energy,
                        Name = x.Name,
                        //SkillsTree = x.SkillsTree,
                        SkillsTreeId = x.SkillsTreeId,
                        Source = x.Source,
                        SourceId = x.SourceId,
                        UpdateDate = x.UpdateDate,
                    })
                .FirstOrDefaultAsync();

            if (singleClass is null)
                throw new CustomException("Существа с таким id не существует");

            var skillTree = await _dbContext.SkillsTree
                   .Where(x => x.Id == singleClass.SkillsTreeId)
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
                   }).FirstOrDefaultAsync();

            singleClass.SkillsTree = skillTree;

            singleClass.SkillsTree.MainSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.MainSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

            singleClass.SkillsTree.FirstLeftSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.FirstLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            singleClass.SkillsTree.SecondLeftSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.SecondLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            singleClass.SkillsTree.ThirdLeftSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.ThirdLeftSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

            singleClass.SkillsTree.FirstMiddleSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.FirstMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            singleClass.SkillsTree.SecondMiddleSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.SecondMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            singleClass.SkillsTree.ThirdMiddleSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.ThirdMiddleSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

            singleClass.SkillsTree.FirstRightSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.FirstRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            singleClass.SkillsTree.SecondRightSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.SecondRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();
            singleClass.SkillsTree.ThirdRightSkill = await _dbContext.Skills.Where(x => x.Id == singleClass.SkillsTree.ThirdRightSkillId).Include(x => x.Stat).FirstOrDefaultAsync();

            ClassResponce responce = new()
            {
                Count = 1,
                Entitys = new List<ClassResponceDTO>() { singleClass },
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
