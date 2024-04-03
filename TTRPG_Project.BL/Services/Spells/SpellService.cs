using AutoMapper;
using Azure;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Immutable;
using System.Drawing.Printing;
using System.Linq;
using System.Security.AccessControl;
using TTRPG_Project.BL.DTO.Creatures.Request;
using TTRPG_Project.BL.DTO.Entities.Creatures.Responce;
using TTRPG_Project.BL.DTO.Entities.Spells.Request;
using TTRPG_Project.BL.DTO.Entities.Spells.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.DTO.Filters;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Spells;

namespace TTRPG_Project.BL.Services.Spells
{
    public class SpellService : BaseService<Spell, int>
    {
        public SpellService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<SpellResponce> GetAllAsync(SpellFilter filter)
        {
            var spells = await _dbContext.Spells.AsNoTracking()
                .Include(s => s.Source)
                .Include(x => x.SpellSkillProtectionList)
                    .ThenInclude(x => x.Skill)
                .Include(x => x.SpellComponentList)
                    .ThenInclude(x => x.Component).ToListAsync();

            foreach (var expression in filter.whereExpression)
            {
                var compiledExpression = expression.Compile();
                spells = spells.Where(compiledExpression).ToList();
            }

            var count = spells.Count();
            var allSpells = spells.OrderBy(x => x.Name).Skip(filter.First).Take(filter.PageSize).ToList();

            SpellResponce responce = new()
            {
                Count = count,
                Entitys = allSpells,
            };

            return responce;
        }

        public async Task<SpellResponce> GetByIdAsync(int id)
        {
            var spell = await _dbContext.Spells.AsNoTracking()
                .Include(s => s.Source)
                .Include(x => x.SpellSkillProtectionList)
                    .ThenInclude(x => x.Skill)
                .Include(x => x.SpellComponentList)
                    .ThenInclude(x => x.Component).FirstOrDefaultAsync();

            SpellResponce responce = new()
            {
                Count = 1,
                Entitys = new List<Spell>() { spell },
            };

            return responce;
        }

        public async Task<bool> CreateAsync(SpellRequest request)
        {
            Spell spell = new()
            {
                CheckDC = request.CheckDC,
                ConcetrationEnduranceCost = request.ConcetrationEnduranceCost,
                DangerInfo = request.DangerInfo,
                Description = request.Description,
                Distance = request.Distance,
                Duration = request.Duration,
                EnduranceCost = request.EnduranceCost,
                IsConcetration = request.IsConcetration,
                IsDruidSpell = request.IsDruidSpell,
                IsPriestSpell = request.IsPriestSpell,
                PreparationTime = request.PreparationTime,
                Name = request.Name,
                SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2,
                SourceType = request.SourceType,
                SourceTypeDescription = request.SourceTypeDescription,
                SpellComponentList = request.SpellComponentList.Select(dto => new SpellComponentList
                {
                    Amount = dto.Amount,
                    ComponentId = dto.ComponentId ?? dto.Component?.Id,
                }).ToList(),
                SpellLevel = request.SpellLevel,
                SpellSkillProtectionList = request.SpellSkillProtectionList.Select(dto => new SpellSkillProtectionList
                {
                    SpellId = dto.SpellId ?? dto.Spell.Id,
                }).ToList(),
                SpellType = request.SpellType,
                SpellTypeDescription = request.SpellTypeDescription,
                WithdrawalCondition = request.WithdrawalCondition
            };

            await _dbContext.Spells.AddAsync(spell);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(SpellRequest request)
        {
            var spell = await _dbContext.Spells.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (spell is null)
                throw new CustomException("Существо не найдено!");

            spell.CheckDC = request.CheckDC;
            spell.ConcetrationEnduranceCost = request.ConcetrationEnduranceCost;
            spell.DangerInfo = request.DangerInfo;
            spell.Description = request.Description;
            spell.Distance = request.Distance;
            spell.Duration = request.Duration;
            spell.EnduranceCost = request.EnduranceCost;
            spell.IsConcetration = request.IsConcetration;
            spell.IsDruidSpell = request.IsDruidSpell;
            spell.IsPriestSpell = request.IsPriestSpell;
            spell.PreparationTime = request.PreparationTime;
            spell.Name = request.Name;
            spell.SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2;
            spell.SourceType = request.SourceType;
            spell.SourceTypeDescription = request.SourceTypeDescription;
            spell.SpellLevel = request.SpellLevel;
            spell.SpellType = request.SpellType;
            spell.SpellTypeDescription = request.SpellTypeDescription;
            spell.WithdrawalCondition = request.WithdrawalCondition;
            spell.UpdateDate = DateTime.Now;

            var scList = await _dbContext.SpellComponentList.Where(x => x.SpellId == spell.Id).ToListAsync();
            _dbContext.RemoveRange(scList);
            spell.SpellComponentList = request.SpellComponentList.Select(dto => new SpellComponentList
                {
                    Amount = dto.Amount,
                    ComponentId = dto.ComponentId ?? dto.Component?.Id,
                }).ToList();

            var sspList = await _dbContext.SpellSkillProtectionList.Where(x => x.SpellId == spell.Id).ToListAsync();
            _dbContext.RemoveRange(sspList);
            spell.SpellSkillProtectionList = request.SpellSkillProtectionList.Select(dto => new SpellSkillProtectionList
            {
                SpellId = dto.SpellId ?? dto.Spell.Id,
            }).ToList();
            _dbContext.Entry(spell).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var spell = await _dbContext.Spells.FindAsync(id);
            if (spell is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(spell);
            return await SaveAsync();
        }
    }
}
