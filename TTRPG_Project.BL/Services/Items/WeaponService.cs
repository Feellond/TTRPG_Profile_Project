using Microsoft.EntityFrameworkCore;
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
                .Include(ibe => ibe.Skill)
                .Select(item => new ItemBaseInfo
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = (item.Source != null ? item.Source.Name : ""),
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectList = item.ItemBaseEffectList,
                    ItemType = (int)ItemEntityType.Tool,
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
                }).ToListAsync();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Items = weapons,
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
                .Include(ibe => ibe.Skill)
                .Select(item => new ItemBaseInfo
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = (item.Source != null ? item.Source.Name : ""),
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectList = item.ItemBaseEffectList,
                    ItemType = (int)ItemEntityType.Tool,
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
                }).FirstOrDefault();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Items = new List<ItemBaseInfo>() { weapon },
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
                ItemBaseEffectList = request.ItemBaseEffectList.Select(dto => new ItemBaseEffectList
                {
                    ChancePercent = dto.ChancePercent,
                    Damage = dto.Damage,
                    EffectId = dto.Effect?.Id ?? 0,
                    IsDealDamage = dto.IsDealDamage,
                }).ToList(),
                Name = request.Name,
                Price = request.Price,
                SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2,
                Weight = request.Weight,
                StealthType = request.StealthType,
                Type = request.Type,
                EquipmentType = request.EquipmentType,
                Accuracy = request.Accuracy,
                Damage = request.Damage,
                Reliability = request.Reliability,
                Grip = request.Grip,
                Distance = request.Distance,
                AmountOfEnhancements = request.AmountOfEnhancements,
                IsAmmunition = request.IsAmmunition,
                SkillId = request.SkillId ?? request.Skill?.Id,
            };

            await _dbContext.Weapons.AddAsync(newWeapon);
            return await SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(WeaponRequest request)
        {
            var tool = _dbContext.Weapons.Where(x => x.Id == request.Id).FirstOrDefault();
            if (tool is null)
                throw new CustomException("Оружие не не найдено!");

            tool.Name = request.Name;
            tool.UpdateDate = DateTime.Now;
            tool.Weight = request.Weight;
            tool.Price = request.Price;
            tool.SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2;
            tool.Description = request.Description;
            tool.AvailabilityType = request.AvailabilityType;
            tool.StealthType = request.StealthType;
            tool.Type = request.Type;
            tool.EquipmentType = request.EquipmentType;
            tool.Accuracy = request.Accuracy;
            tool.Damage = request.Damage;
            tool.Reliability = request.Reliability;
            tool.Grip = request.Grip;
            tool.Distance = request.Distance;
            tool.AmountOfEnhancements = request.AmountOfEnhancements;
            tool.IsAmmunition = request.IsAmmunition;
            tool.SkillId = request.SkillId ?? request.Skill?.Id;

            var tbeList = await _dbContext.ItemBaseEffectList.Where(x => x.ItemBaseId == tool.Id).ToListAsync();
            _dbContext.RemoveRange(tbeList);

            tool.ItemBaseEffectList = request.ItemBaseEffectList.Select(dto => new ItemBaseEffectList
            {
                Id = dto.Id ?? 0,
                ItemBaseId = tool.Id,
                ChancePercent = dto.ChancePercent,
                Damage = dto.Damage,
                EffectId = dto.Effect?.Id ?? 0,
                IsDealDamage = dto.IsDealDamage,
            }).ToList();

            _dbContext.Entry(tool).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var weapon = await _dbContext.Weapons.FindAsync(id);
            if (weapon is null)
                throw new CustomException("Оружие не не найдено!");

            _dbContext.Remove(weapon);
            return await SaveAsync();
        }
    }
}
