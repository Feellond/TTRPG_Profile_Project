﻿using AutoMapper;
using Azure;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System.Collections.Immutable;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
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
using TTRPG_Project.DAL.Entities.Database.Users;

namespace TTRPG_Project.BL.Services.Creatures
{
    public class CreatureService : BaseService<Creature, int>
    {
        private IMemoryCache cache;
        public CreatureService(ApplicationDbContext dbContext, IMemoryCache memoryCache) : base(dbContext) 
        {
            cache = memoryCache;
        }

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
                    .ThenInclude(r => r.Source)
                .Include(stats => stats.StatsList)
                .Include(skills => skills.SkillsList)
                .Include(a => a.CreatureAttacks)
                    .ThenInclude(x => x.Attack)
                        .ThenInclude(ael => ael.AttackEffectList)
                            .ThenInclude(e => e.Effect)
                                .ThenInclude(s => s.Source)
                .Include(ab => ab.CreatureAbilitys)
                    .ThenInclude(r => r.Ability)
                        .ThenInclude(s => s.Source)
                .Include(crl => crl.CreatureReward)
                    .ThenInclude(item => item.ItemBase)
                        .ThenInclude(s => s.Source)
                .Include(m => m.Mutagen)
                    .ThenInclude(m => m.Source)
                .Include(t => t.Trophy)
                    .ThenInclude(t => t.Source)
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
                        CreatureAttacks = creature.CreatureAttacks.Select(e => new CreatureAttack
                        {
                            Id = e.Id,
                            AttackId = e.AttackId,
                            Attack = e.Attack == null ? null : new Attack
                            {
                                Id = e.Attack.Id,
                                AttackSpeed = e.Attack.AttackSpeed,
                                AttackType = e.Attack.AttackType,
                                BaseAttack = e.Attack.BaseAttack,
                                Damage = e.Attack.Damage,
                                Description = e.Attack.Description,
                                Distance = e.Attack.Distance,
                                Name = e.Attack.Name,
                                Reliability = e.Attack.Reliability,
                                SourceId = e.Attack.SourceId,
                                Source = e.Attack.Source,
                                CreateDate = e.Attack.CreateDate,
                                UpdateDate = e.Attack.UpdateDate,
                                Enabled = e.Attack.Enabled,
                                AttackEffectList = e.Attack.AttackEffectList.Select(e => new AttackEffectList
                                {
                                    Id = e.Id,
                                    ChancePercent = e.ChancePercent,
                                    Damage = e.Damage,
                                    EffectId = e.EffectId,
                                    Effect = e.Effect,
                                    IsDealDamage = e.IsDealDamage,
                                }).ToList(),
                            }
                        }).ToList(),
                        CreatureReward = creature.CreatureReward,
                        EducationSkill = creature.EducationSkill,
                        EvasionBase = creature.EvasionBase,
                        GroupSize = creature.GroupSize,
                        HabitatPlace = creature.HabitatPlace,
                        //Resistances = creature.Resistances,
                        Height = creature.Height,
                        Intellect = creature.Intellect,
                        MoneyReward = creature.MoneyReward,
                        //Immunities = creature.Immunities,
                        //Vulnerabilities = creature.Vulnerabilities,
                        CreatureEffects = creature.CreatureEffects,
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
                        Mutagen = creature.Mutagen,
                        Trophy = creature.Trophy,
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
            CreatureResponce responce;

            if (!cache.TryGetValue(id, out responce))
            {
                var creature = await _dbContext.Creatures.AsNoTracking()
                    .Where(x => x.Id == id)
                    .Include(s => s.Source)
                    .Include(r => r.Race)
                        .ThenInclude(s => s.Source)
                    .Include(stats => stats.StatsList)
                    .Include(skills => skills.SkillsList)
                    .Include(a => a.CreatureAttacks)
                        .ThenInclude(x => x.Attack)
                            .ThenInclude(ael => ael.AttackEffectList)
                                .ThenInclude(e => e.Effect)
                    .Include(ab => ab.CreatureAbilitys)
                        .ThenInclude(r => r.Ability)
                    .Include(crl => crl.CreatureReward)
                        .ThenInclude(item => item.ItemBase)
                            .ThenInclude(s => s.Source)
                    .Include(m => m.Mutagen)
                        .ThenInclude(m => m.Source)
                    .Include(t => t.Trophy)
                        .ThenInclude(t => t.Source)
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
                            CreatureAttacks = creature.CreatureAttacks.Select(e => new CreatureAttack
                            {
                                Id = e.Id,
                                AttackId = e.AttackId,
                                Attack = e.Attack == null ? null : new Attack
                                {
                                    Id = e.Attack.Id,
                                    AttackSpeed = e.Attack.AttackSpeed,
                                    AttackType = e.Attack.AttackType,
                                    BaseAttack = e.Attack.BaseAttack,
                                    Damage = e.Attack.Damage,
                                    Description = e.Attack.Description,
                                    Distance = e.Attack.Distance,
                                    Name = e.Attack.Name,
                                    Reliability = e.Attack.Reliability,
                                    SourceId = e.Attack.SourceId,
                                    Source = e.Attack.Source,
                                    CreateDate = e.Attack.CreateDate,
                                    UpdateDate = e.Attack.UpdateDate,
                                    Enabled = e.Attack.Enabled,
                                    AttackEffectList = e.Attack.AttackEffectList.Select(e => new AttackEffectList
                                    {
                                        Id = e.Id,
                                        ChancePercent = e.ChancePercent,
                                        Damage = e.Damage,
                                        EffectId = e.EffectId,
                                        Effect = e.Effect,
                                        IsDealDamage = e.IsDealDamage,
                                    }).ToList(),
                                }
                            }).ToList(),
                            CreatureReward = creature.CreatureReward,
                            EducationSkill = creature.EducationSkill,
                            EvasionBase = creature.EvasionBase,
                            GroupSize = creature.GroupSize,
                            HabitatPlace = creature.HabitatPlace,
                            //Immunities = creature.Immunities,
                            Height = creature.Height,
                            Intellect = creature.Intellect,
                            MoneyReward = creature.MoneyReward,
                            //Resistances = creature.Resistances,
                            //Vulnerabilities = creature.Vulnerabilities,
                            CreatureEffects = creature.CreatureEffects,
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
                            Mutagen = creature.Mutagen,
                            Trophy = creature.Trophy,
                        })
                    .FirstOrDefaultAsync();

                if (creature is null)
                    throw new CustomException("Существа с таким id не существует");

                responce = new()
                {
                    Count = 1,
                    Entitys = new List<CreatureDTO>() { creature }
                };

                cache.Set("creature" + creature.Id, responce,
                    new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(1)));
            }

            return responce;
        }

        public async Task<Creature> CreateAsync(CreatureRequest request)
        {
            try
            {
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
                        //RewardId = dto.RewardId,
                        ItemBaseId = dto.ItemBaseId,
                        Amount = dto.Amount,
                    }).ToList(),
                    Description = request.Description,
                    EducationSkill = request.EducationSkill,
                    EvasionBase = request.EvasionBase,
                    GroupSize = request.GroupSize,
                    HabitatPlace = request.HabitatPlace,
                    Height = request.Height,
                    Intellect = request.Intellect,
                    //Resistances = request.Resistances,
                    //Immunities = request.Immunities,
                    MoneyReward = request.MoneyReward,
                    //Vulnerabilities = request.Vulnerabilities,
                    CreatureEffects = request.CreatureEffects,
                    MonsterLoreInformation = request.MonsterLoreInformation,
                    MonsterLoreSkill = request.MonsterLoreSkill,
                    Name = request.Name,
                    RaceId = request.RaceId ?? request.Race?.Id,
                    Regeneration = request.Regeneration,
                    //SkillsListId = request.SkillsListId ?? request.SkillsList?.Id,
                    SkillsList = request.SkillsList,
                    SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
                    SpellResistBase = request.SpellResistBase,
                    //StatsListId = request.StatsListId ?? request.StatsList?.Id,
                    StatsList = request.StatsList,
                    SuperstitionsInformation = request.SuperstitionsInformation,
                    Weight = request.Weight,
                    ImageFileName = request.ImageFileName,
                    Mutagen = request.Mutagen,
                    Trophy = request.Trophy,
                };

                await _dbContext.Creatures.AddAsync(creature);

                var result = await SaveAsync();
                if (result)
                {
                    return creature;
                }
                else
                    throw new CustomException("Ошибка создания существа!");
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
                var creature = await _dbContext.Creatures.Where(x => x.Id == request.Id)
                    //.Include(s => s.Source)
                    //.Include(r => r.Race)
                    //.Include(stats => stats.StatsList)
                    //.Include(skills => skills.SkillsList)
                    //.Include(a => a.CreatureAttacks)
                    //.Include(ab => ab.CreatureAbilitys)
                    //.Include(crl => crl.CreatureReward)
                    //.Include(m => m.Mutagen)
                    //.Include(t => t.Trophy)
                    .FirstOrDefaultAsync();
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
                //creature.Resistances = request.Resistances;
                //creature.Immunities = request.Immunities;
                //creature.Vulnerabilities = request.Vulnerabilities;
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
                creature.MutagenId = request.Mutagen is null ? null : request.Mutagen.Id;
                creature.Mutagen = request.Mutagen is null ? null : new Mutagen
                {
                    Complexity = request.Mutagen.Complexity,
                    CreateDate = request.Mutagen.CreateDate,
                    Description = request.Mutagen.Description,
                    Effect = request.Mutagen.Effect,
                    Id = request.Mutagen.Id,
                    Mutation = request.Mutagen.Mutation,
                    Name = request.Mutagen.Name,
                    SourceId = request.Mutagen.SourceId ?? 2,
                    UpdateDate = DateTime.Now,
                };
                creature.TrophyId = request.Trophy is null ? null : request.Trophy.Id;
                creature.Trophy = request.Trophy is null ? null : new Trophy
                {
                    CreateDate = request.Trophy.CreateDate,
                    UpdateDate = DateTime.Now,
                    Description = request.Trophy.Description,
                    Id = request.Trophy.Id,
                    Name = request.Trophy.Name,
                    SourceId = request.Trophy.SourceId ?? 2,
                };

                //var caList = await _dbContext.Abilitiys.Where(x => x.Creature == null ? false : x.Creature.Any(k => k.Id == creature.Id)).ToListAsync();
                //_dbContext.RemoveRange(caList);

                creature.CreatureAttacks = request.CreatureAttacks.Select(dto => new CreatureAttack
                {
                    Id = dto.Id,
                    AttackId = dto.AttackId,
                    CreatureId = dto.CreatureId,
                }).ToList();

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
                    ItemBaseId = dto.ItemBaseId,
                    Amount = dto.Amount,
                    //RewardId = dto.RewardId,
                }).ToList();

                creature.CreatureEffects = request.CreatureEffects.Select(dto => new CreatureEffect 
                {
                    Id = dto.Id,
                    CreatureId = dto.CreatureId,
                    EffectId = dto.EffectId,
                    Description = dto.Description,
                    Name = dto.Name,
                    Type = dto.Type,
                    UpdateDate = DateTime.Now,
                }).ToList();

                cache.Remove("creature" + creature.Id);

                _dbContext.Entry(creature).State = EntityState.Modified;
                var result = await SaveAsync();

                if (result) cache.Remove("creature" + creature.Id);
                
                return result;
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

            var skillList = await _dbContext.SkillsList.FindAsync(creature.SkillsListId);
            if (skillList is null)
                throw new CustomException("Список способностей не найден!");

            var statList = await _dbContext.StatsList.FindAsync(creature.StatsListId);
            if (statList is null)
                throw new CustomException("Список статов не найден!");

            var deleteFilePath = creature.ImageFileName;
            _dbContext.Remove(skillList);
            _dbContext.Remove(statList);
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
