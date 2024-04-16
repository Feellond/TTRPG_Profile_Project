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
using TTRPG_Project.BL.DTO.Entities.Creatures;
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
                .Include(ab => ab.CreatureAbilitys)
                    .ThenInclude(r => r.Ability)
                .Include(crl => crl.CreatureReward)
                    .ThenInclude(reward => reward.Reward)
                        .ThenInclude(item => item.ItemBase)
                    .Select(creature => new CreatureDTO
                    {
                        Id = creature.Id,
                        Name = creature.Name,
                        Description = creature.Description,
                        Source = creature.Source,
                        CreatureAbilitys = creature.CreatureAbilitys,
                        AdditionalInformation = creature.AdditionalInformation,
                        Armor = creature.Armor,
                        AthleticsBase = creature.AthleticsBase,
                        BlockBase = creature.BlockBase,
                        Complexity = creature.Complexity,
                        CreatureAttacks = creature.CreatureAttacks,
                        CreatureReward = creature.CreatureReward,
                        EducationSkill = creature.EducationSkill,
                        EvasionBase = creature.EvasionBase,
                        GroupSize = creature.GroupSize,
                        HabitatPlace = creature.HabitatPlace,
                        Resistances = creature.Resistances,
                        Height = creature.Height,
                        Intellect = creature.Intellect,
                        MoneyReward = creature.MoneyReward,
                        Immunities = creature.Immunities,
                        Vulnerabilities = creature.Vulnerabilities,
                        MonsterLoreInformation = creature.MonsterLoreInformation,
                        MonsterLoreSkill = creature.MonsterLoreSkill,
                        Race = creature.Race,
                        RaceId = creature.RaceId,
                        Regeneration = creature.Regeneration,
                        SkillsList = creature.SkillsList,
                        SkillsListId = creature.SkillsListId,
                        SpellResistBase = creature.SpellResistBase,
                        Spells = creature.Spells,
                        StatsList = creature.StatsList,
                        StatsListId = creature.StatsListId,
                        SuperstitionsInformation = creature.SuperstitionsInformation,
                        Weight = creature.Weight,
                        ImageFileName = creature.ImageFileName,
                    })
                    .ToListAsync();

            foreach (var expression in filter.whereExpression)
            {
                var compiledExpression = expression.Compile();
                creatures = creatures.Where(compiledExpression).ToList();
            }

            var count = creatures.Count();
            var allCreatures = creatures.OrderBy(x => x.Name).Skip(filter.First).Take(filter.PageSize).ToList();

            CreatureResponce responce = new()
            {
                Count = count,
                Entitys = allCreatures,
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
                .Include(ab => ab.CreatureAbilitys)
                    .ThenInclude(r => r.Ability)
                .Include(crl => crl.CreatureReward)
                    .ThenInclude(reward => reward.Reward)
                        .ThenInclude(item => item.ItemBase)
                    .Select(creature => new CreatureDTO
                    {
                        Id = creature.Id,
                        Name = creature.Name,
                        Description = creature.Description,
                        Source = creature.Source,
                        CreatureAbilitys = creature.CreatureAbilitys,
                        AdditionalInformation = creature.AdditionalInformation,
                        Armor = creature.Armor,
                        AthleticsBase = creature.AthleticsBase,
                        BlockBase = creature.BlockBase,
                        Complexity = creature.Complexity,
                        CreatureAttacks = creature.CreatureAttacks,
                        CreatureReward = creature.CreatureReward,
                        EducationSkill = creature.EducationSkill,
                        EvasionBase = creature.EvasionBase,
                        GroupSize = creature.GroupSize,
                        HabitatPlace = creature.HabitatPlace,
                        Immunities = creature.Immunities,
                        Height = creature.Height,
                        Intellect = creature.Intellect,
                        MoneyReward = creature.MoneyReward,
                        Resistances = creature.Resistances,
                        Vulnerabilities = creature.Vulnerabilities,
                        MonsterLoreInformation = creature.MonsterLoreInformation,
                        MonsterLoreSkill = creature.MonsterLoreSkill,
                        Race = creature.Race,
                        RaceId = creature.RaceId,
                        Regeneration = creature.Regeneration,
                        SkillsList = creature.SkillsList,
                        SkillsListId = creature.SkillsListId,
                        SpellResistBase = creature.SpellResistBase,
                        Spells = creature.Spells,
                        StatsList = creature.StatsList,
                        StatsListId = creature.StatsListId,
                        SuperstitionsInformation = creature.SuperstitionsInformation,
                        Weight = creature.Weight,
                        ImageFileName = creature.ImageFileName,
                    })
                .FirstOrDefaultAsync();

            if (creature is null)
                throw new CustomException("Существа с таким id не существует");

            CreatureResponce responce = new()
            {
                Count = 1,
                Entitys = new List<CreatureDTO>() { creature }
            };

            return responce;
        }

        public async Task<bool> CreateAsync(CreatureRequest request)
        {
            try
            {
                //if (request.File != null)
                //{
                //    if (request.File.Length == 0)
                //        throw new CustomException("Недопустимый размер файла.");

                //    if (request.File.ContentType != "image/jpeg" && request.File.ContentType != "image/png")
                //        throw new CustomException("Недопустимый формат файла. Допускаются только JPEG и PNG.");

                //    if (request.File.FileName.Contains("/") || request.File.FileName.Contains("\\"))
                //        throw new CustomException("Недопустимое имя файла.");
                //}

                Creature creature = new()
                {
                    CreatureAbilitys = request.CreatureAbilitys.Select(dto => new CreatureAbility
                    {
                        AbilityId = dto.AbilityId,
                        CreatureId = dto.CreatureId,
                    }).ToList(),
                    AdditionalInformation = request.AdditionalInformation,
                    Armor = request.Armor,
                    AthleticsBase = request.AthleticsBase,
                    CreatureAttacks = request.CreatureAttacks,
                    BlockBase = request.BlockBase,
                    Complexity = request.Complexity,
                    CreatureReward = request.CreatureReward.Select(dto => new CreatureReward
                    {
                        CreatureId = dto.CreatureId,
                        RewardId = dto.RewardId,
                    }).ToList(),
                    Description = request.Description,
                    EducationSkill = request.EducationSkill,
                    EvasionBase = request.EvasionBase,
                    GroupSize = request.GroupSize,
                    HabitatPlace = request.HabitatPlace,
                    Height = request.Height,
                    Intellect = request.Intellect,
                    Resistances = request.Resistances,
                    Immunities = request.Immunities,
                    MoneyReward = request.MoneyReward,
                    Vulnerabilities = request.Vulnerabilities,
                    MonsterLoreInformation = request.MonsterLoreInformation,
                    MonsterLoreSkill = request.MonsterLoreSkill,
                    Name = request.Name,
                    RaceId = request.RaceId ?? request.Race?.Id,
                    Regeneration = request.Regeneration,
                    SkillsListId = request.SkillsListId ?? request.SkillsList?.Id,
                    SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
                    SpellResistBase = request.SpellResistBase,
                    StatsListId = request.StatsListId ?? request.StatsList?.Id,
                    SuperstitionsInformation = request.SuperstitionsInformation,
                    Weight = request.Weight,
                    ImageFileName = request.ImageFileName,
                };

                await _dbContext.Creatures.AddAsync(creature);
                //await SaveAsync();

                //if (request.File != null)
                //{
                //    var filePath = Path.Combine("Images\\Creature", request.File.FileName + "_ID" + creature.Id);
                //    using (var stream = new FileStream(filePath, FileMode.Create))
                //    {
                //        request.File.CopyTo(stream);

                //        creature.ImageFileName = filePath;
                //        _dbContext.Entry(creature).State = EntityState.Modified;
                //    }
                //}

                return await SaveAsync();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }
        }

        public async Task<bool> UpdateAsync(CreatureRequest request)
        {
            try
            {
                var creature = await _dbContext.Creatures.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (creature is null)
                    throw new CustomException("Существо не найдено!");

                //if (request.File != null)
                //{
                //    if (request.File.Length == 0)
                //        throw new CustomException("Недопустимый размер файла.");

                //    if (request.File.ContentType != "image/jpeg" && request.File.ContentType != "image/png")
                //        throw new CustomException("Недопустимый формат файла. Допускаются только JPEG и PNG.");

                //    if (request.File.FileName.Contains("/") || request.File.FileName.Contains("\\"))
                //        throw new CustomException("Недопустимое имя файла.");
                //}

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
                creature.Resistances = request.Resistances;
                creature.Immunities = request.Immunities;
                creature.Vulnerabilities = request.Vulnerabilities;
                creature.MonsterLoreInformation = request.MonsterLoreInformation;
                creature.MonsterLoreSkill = request.MonsterLoreSkill;
                creature.Name = request.Name;
                creature.RaceId = request.RaceId ?? request.Race?.Id;
                creature.Regeneration = request.Regeneration;
                creature.SkillsListId = request.SkillsListId ?? request.SkillsList?.Id;
                creature.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
                creature.SpellResistBase = request.SpellResistBase;
                creature.StatsListId = request.StatsListId ?? request.StatsList?.Id;
                creature.SuperstitionsInformation = request.SuperstitionsInformation;
                creature.Weight = request.Weight;
                creature.UpdateDate = DateTime.Now;
                creature.ImageFileName = request.ImageFileName;

                //var caList = await _dbContext.Abilitiys.Where(x => x.Creature == null ? false : x.Creature.Any(k => k.Id == creature.Id)).ToListAsync();
                //_dbContext.RemoveRange(caList);
                creature.CreatureAbilitys = request.CreatureAbilitys.Select(dto => new CreatureAbility
                {
                    Id = dto.Id,
                    AbilityId = dto.AbilityId,
                    CreatureId = dto.CreatureId,
                }).ToList();

                //var ccrList = await _dbContext.CreatureRewardList.Where(x => x.CreatureId == creature.Id).ToListAsync();
                //_dbContext.RemoveRange(ccrList);
                creature.CreatureReward = request.CreatureReward.Select(dto => new CreatureReward
                {
                    Id = dto.Id,
                    CreatureId = dto.CreatureId,
                    RewardId = dto.RewardId,
                }).ToList();

                //if (request.File != null)
                //{
                //    var deleteFilePath = creature.ImageFileName;
                //    if (File.Exists(deleteFilePath))
                //    {
                //        File.Delete(deleteFilePath);
                //    }

                //    //var filePath = Path.Combine(Environment.CurrentDirectory, "Images\\Creature", request.File.FileName);
                //    var filePath = Path.Combine("Images\\Creature", request.File.FileName);
                //    using (var stream = new FileStream(filePath, FileMode.Create))
                //    {
                //        request.File.CopyTo(stream);

                //        creature.ImageFileName = filePath;
                //        _dbContext.Entry(creature).State = EntityState.Modified;
                //    }
                //}

                _dbContext.Entry(creature).State = EntityState.Modified;
                return await SaveAsync();
            }
            catch (Exception ex)
            {
                throw new CustomException(ex.Message);
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var creature = await _dbContext.Creatures.FindAsync(id);
            if (creature is null)
                throw new CustomException("Существо не найдено!");

            var deleteFilePath = creature.ImageFileName;
            _dbContext.Remove(creature);
            var saved = await SaveAsync();

            if (saved)
            {
                if (File.Exists(deleteFilePath))
                {
                    File.Delete(deleteFilePath);
                }
            }

            return saved;
        }
    }
}
