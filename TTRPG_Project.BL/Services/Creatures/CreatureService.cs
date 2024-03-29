using AutoMapper;
using Azure;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Immutable;
using System.Drawing.Printing;
using System.Linq;
using TTRPG_Project.BL.DTO.Creatures;
using TTRPG_Project.BL.DTO.Creatures.Request;
using TTRPG_Project.BL.DTO.Entities.Creatures.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.DTO.Filters;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.Services.Creatures
{
    public class CreatureService : BaseService<Creature, int>
    {
        public CreatureService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<CreatureResponce> GetAllAsync(CreatureFilter filter)
        {
            //var creatures = await _dbContext.Creatures.AsNoTracking()
            //    .Include(s => s.Source)
            //    .Include(r => r.Race)
            //    .Include(stats => stats.StatsList)
            //    .Include(skills => skills.SkillsList)
            //    .Include(a => a.Attacks)
            //        .ThenInclude(ael => ael.AttackEffectList)
            //            .ThenInclude(e => e.Effect)
            //    .Include(ab => ab.Abilities)
            //        .ThenInclude(r => r.Race)
            //    .Include(crl => crl.CreatureRewardList)
            //        .ThenInclude(item => item.ItemBase).ToListAsync();

            var creatures = await _dbContext.Creatures.AsNoTracking()
                .Include(s => s.Source)
                .Include(r => r.Race)
                .Include(stats => stats.StatsList)
                .Include(skills => skills.SkillsList)
                .Include(a => a.CreatureAttacks)
                    .ThenInclude(x => x.Attack)
                        .ThenInclude(ael => ael.AttackEffectList)
                            .ThenInclude(e => e.Effect)
                .Include(ab => ab.Abilities)
                    .ThenInclude(r => r.Race)
                .Include(crl => crl.CreatureRewardList)
                    .ThenInclude(item => item.ItemBase).ToListAsync();

            foreach (var expression in filter.whereExpression)
            {
                var compiledExpression = expression.Compile();
                creatures = creatures.Where(compiledExpression).ToList();
            }

            var count = creatures.Count();
            var allCreatures = creatures.OrderBy(x => x.Name).Skip(filter.First).Take(filter.Page).ToList();

            CreatureResponce responce = new()
            {
                Count = count,
                Creatures = allCreatures,
            };

            return responce;
        }

        public async Task<CreatureResponce> GetByIdAsync(int id)
        {
            var creature = await _dbContext.Creatures.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(r => r.Race)
                .Include(stats => stats.StatsList)
                .Include(skills => skills.SkillsList)
                .Include(a => a.CreatureAttacks)
                    .ThenInclude(x => x.Attack)
                        .ThenInclude(ael => ael.AttackEffectList)
                            .ThenInclude(e => e.Effect)
                .Include(ab => ab.Abilities)
                    .ThenInclude(r => r.Race)
                .Include(crl => crl.CreatureRewardList)
                    .ThenInclude(item => item.ItemBase)
                .FirstOrDefaultAsync();

            if (creature is null)
                throw new CustomException("Существа с таким id не существует");

            CreatureResponce responce = new()
            {
                Count = 1,
                Creatures = new List<Creature>() { creature }
            };

            return responce;
        }

        public async Task<bool> CreateAsync(CreatureRequest request)
        {
            Creature creature = new()
            {
                Abilities = request.Abilities.Select(dto => new Ability
                {
                    Name = dto.Name,
                    RaceId = dto.RaceId ?? dto.Race?.Id,
                    Type = dto.Type,
                    Description = dto.Description,
                    SourceId = _dbContext.Sources.Where(x => x.Name == ((dto.Source == null) ? "" : dto.Source.Name)).FirstOrDefault()?.Id ?? 2,
                }).ToList(),
                AdditionalInformation = request.AdditionalInformation,
                Armor = request.Armor,
                AthleticsBase = request.AthleticsBase,
                CreatureAttacks = request.CreatureAttacks,
                BlockBase = request.BlockBase,
                Complexity = request.Complexity,
                CreatureRewardList = request.CreatureRewardList.Select(dto => new CreatureRewardList
                {
                    Amount = dto.Amount,
                    ItemBaseId = dto.ItemBaseId ?? dto.ItemBase?.Id,
                }).ToList(),
                Description = request.Description,
                EducationSkill = request.EducationSkill,
                EvasionBase = request.EvasionBase,
                GroupSize = request.GroupSize,
                HabitatPlace = request.HabitatPlace,
                Height = request.Height,
                Intellect = request.Intellect,
                MoneyReward = request.MoneyReward,
                MonsterLoreInformation = request.MonsterLoreInformation,
                MonsterLoreSkill = request.MonsterLoreSkill,
                Name = request.Name,
                RaceId = request.RaceId ?? request.Race?.Id,
                Regeneration = request.Regeneration,
                SkillsListId = request.SkillsListId ?? request.SkillsList?.Id,
                SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2,
                SpellResistBase = request.SpellResistBase,
                StatsListId = request.StatsListId?? request.StatsList?.Id,
                SuperstitionsInformation = request.SuperstitionsInformation,
                Weight = request.Weight,
            };

            await _dbContext.Creatures.AddAsync(creature);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(CreatureRequest request)
        {
            var creature = await _dbContext.Creatures.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (creature is null)
                throw new CustomException("Существо не найдено!");

            creature.AdditionalInformation = request.AdditionalInformation;
            creature.Armor = request.Armor;
            creature.AthleticsBase = request.AthleticsBase;
            creature.CreatureAttacks = request.CreatureAttacks;
            creature.BlockBase = request.BlockBase;
            creature.Complexity = request.Complexity;
            creature.Description = request.Description;
            creature.EducationSkill = request.EducationSkill;
            creature.EvasionBase = request.EvasionBase;
            creature.GroupSize = request.GroupSize;
            creature.HabitatPlace = request.HabitatPlace;
            creature.Height = request.Height;
            creature.Intellect = request.Intellect;
            creature.MoneyReward = request.MoneyReward;
            creature.MonsterLoreInformation = request.MonsterLoreInformation;
            creature.MonsterLoreSkill = request.MonsterLoreSkill;
            creature.Name = request.Name;
            creature.RaceId = request.RaceId ?? request.Race?.Id;
            creature.Regeneration = request.Regeneration;
            creature.SkillsListId = request.SkillsListId ?? request.SkillsList?.Id;
            creature.SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2;
            creature.SpellResistBase = request.SpellResistBase;
            creature.StatsListId = request.StatsListId ?? request.StatsList?.Id;
            creature.SuperstitionsInformation = request.SuperstitionsInformation;
            creature.Weight = request.Weight;
            creature.UpdateDate = DateTime.Now;

            //var caList = await _dbContext.Abilitiys.Where(x => x.Creature == null ? false : x.Creature.Any(k => k.Id == creature.Id)).ToListAsync();
            //_dbContext.RemoveRange(caList);
            creature.Abilities = request.Abilities.Select(dto => new Ability
            {
                Id = dto.Id,
                Name = dto.Name,
                RaceId = dto.RaceId ?? dto.Race?.Id,
                Type = dto.Type,
                Description = dto.Description,
                SourceId = _dbContext.Sources.Where(x => x.Name == ((dto.Source == null) ? "" : dto.Source.Name)).FirstOrDefault()?.Id ?? 2,
            }).ToList();

            //var ccrList = await _dbContext.CreatureRewardList.Where(x => x.CreatureId == creature.Id).ToListAsync();
            //_dbContext.RemoveRange(ccrList);
            creature.CreatureRewardList = request.CreatureRewardList.Select(dto => new CreatureRewardList
            {
                Id = dto.Id ?? 0,
                Amount = dto.Amount,
                ItemBaseId = dto.ItemBaseId ?? dto.ItemBase?.Id,
            }).ToList();

            _dbContext.Entry(creature).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var creature = await _dbContext.Creatures.FindAsync(id);
            if (creature is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(creature);
            return await SaveAsync();
        }
    }
}
