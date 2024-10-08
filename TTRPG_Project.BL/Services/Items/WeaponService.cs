﻿using Microsoft.EntityFrameworkCore;
using TTRPG_Project.BL.DTO.Entities.Items;
using TTRPG_Project.BL.DTO.Entities.Items.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.DTO.Items.Request;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.Services.Items
{
    public class WeaponService : BaseService<Weapon, int>
    {
        public WeaponService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<ItemBaseResponce> GetAllAsync()
        {
            var weapons = await _dbContext.Weapons.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Include(ibe => ibe.Skill)
                    .ThenInclude(s => s.Source)
                .Select(item => new ItemBaseInfo
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = item.Source,
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectList = item.ItemBaseEffectList,
                    ItemType = (int)ItemEntityType.Tool,
                    StealthType = item.StealthType,
                    Type = item.Type,
                    ItemOriginType = item.ItemOriginType,
                    EquipmentType = item.EquipmentType,
                    Accuracy = item.Accuracy,
                    Damage = item.Damage,
                    Reliability = item.Reliability,
                    Grip = item.Grip,
                    Distance = item.Distance,
                    AmountOfEnhancements = item.AmountOfEnhancements,
                    IsAmmunition = item.IsAmmunition,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = weapons,
            };

            return responce;
        }

        public async Task<ItemBaseResponce?> GetByIdAsync(int id)
        {
            var weapon = _dbContext.Weapons.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Include(ibe => ibe.Skill)
                    .ThenInclude(s => s.Source)
                .Select(item => new ItemBaseInfo
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = item.Source,
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectList = item.ItemBaseEffectList,
                    ItemType = (int)ItemEntityType.Tool,
                    ItemOriginType = item.ItemOriginType,
                    StealthType = item.StealthType,
                    Type = item.Type,
                    EquipmentType = item.EquipmentType,
                    Accuracy = item.Accuracy,
                    Damage = item.Damage,
                    Reliability = item.Reliability,
                    Grip = item.Grip,
                    Distance = item.Distance,
                    AmountOfEnhancements = item.AmountOfEnhancements,
                    IsAmmunition = item.IsAmmunition,
                    ImageFileName = item.ImageFileName,
                }).FirstOrDefault();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = new List<ItemBaseInfo>() { weapon },
            };

            return responce;
        }

        public virtual async Task<bool> CreateAsync(WeaponRequest request)
        {
            Weapon newWeapon = new Weapon()
            {
                AvailabilityType = request.AvailabilityType,
                Description = request.Description,
                Id = request.Id,
                ItemType = (ItemType)ItemEntityType.Weapon,
                ItemBaseEffectList = request.ItemBaseEffectList?.Select(dto => new ItemBaseEffectList
                {
                    ChancePercent = dto.ChancePercent,
                    Damage = dto.Damage,
                    EffectId = dto.Effect?.Id ?? 0,
                    IsDealDamage = dto.IsDealDamage,
                }).ToList() ?? new List<ItemBaseEffectList>(),
                Name = request.Name,
                Price = request.Price,
                SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2, 
                Weight = request.Weight,
                StealthType = request.StealthType,
                Type = request.Type,
                EquipmentType = request.EquipmentType,
                Accuracy = request.Accuracy,
                Damage = request.Damage,
                Reliability = request.Reliability,
                ItemOriginType = request.ItemOriginType,
                Grip = request.Grip,
                Distance = request.Distance,
                AmountOfEnhancements = request.AmountOfEnhancements,
                IsAmmunition = request.IsAmmunition,
                SkillId = request.SkillId ?? request.Skill?.Id,
                ImageFileName = request.ImageFileName,
            };

            await _dbContext.Weapons.AddAsync(newWeapon);
            return await SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(WeaponRequest request)
        {
            var weapon = _dbContext.Weapons.Where(x => x.Id == request.Id).FirstOrDefault();
            if (weapon is null)
                throw new CustomException("Оружие не не найдено!");

            weapon.Name = request.Name;
            weapon.UpdateDate = DateTime.Now;
            weapon.Weight = request.Weight;
            weapon.Price = request.Price;
            weapon.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            weapon.Description = request.Description;
            weapon.AvailabilityType = request.AvailabilityType;
            weapon.StealthType = request.StealthType;
            weapon.Type = request.Type;
            weapon.ItemOriginType = request.ItemOriginType;
            weapon.EquipmentType = request.EquipmentType;
            weapon.Accuracy = request.Accuracy;
            weapon.Damage = request.Damage;
            weapon.Reliability = request.Reliability;
            weapon.Grip = request.Grip;
            weapon.Distance = request.Distance;
            weapon.AmountOfEnhancements = request.AmountOfEnhancements;
            weapon.IsAmmunition = request.IsAmmunition;
            weapon.SkillId = request.SkillId ?? request.Skill?.Id;
            weapon.ImageFileName = request.ImageFileName;

            var tbeList = await _dbContext.ItemBaseEffectList.Where(x => x.ItemBaseId == weapon.Id).ToListAsync();
            _dbContext.RemoveRange(tbeList);

            weapon.ItemBaseEffectList = request.ItemBaseEffectList?.Select(dto => new ItemBaseEffectList
            {
                Id = dto.Id,
                ItemBaseId = weapon.Id,
                ChancePercent = dto.ChancePercent,
                Damage = dto.Damage,
                EffectId = dto.Effect?.Id ?? 0,
                IsDealDamage = dto.IsDealDamage,
            }).ToList() ?? new List<ItemBaseEffectList>();

            _dbContext.Entry(weapon).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var weapon = await _dbContext.Weapons.Include(x => x.ItemBaseEffectList).Where(x => x.Id == id).FirstOrDefaultAsync();
            if (weapon is null)
                throw new CustomException("Оружие не не найдено!");

            weapon.ItemBaseEffectList = new List<ItemBaseEffectList>();

            _dbContext.Remove(weapon);
            return await SaveAsync();
        }
    }
}
