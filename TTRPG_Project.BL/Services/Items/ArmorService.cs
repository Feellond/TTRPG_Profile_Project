using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using TTRPG_Project.BL.DTO.Entities.Items;
using TTRPG_Project.BL.DTO.Entities.Items.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.DTO.Items.Request;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.Services.Items
{
    public class ArmorService : BaseService<Armor, int>
    {
        public ArmorService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<ItemBaseResponce> GetAllAsync()
        {
            var armors = await _dbContext.Armors.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
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
                    ItemType = (int)ItemEntityType.Armor,
                    Type = item.Type,
                    EquipmentType = item.EquipmentType,
                    Reliability = item.Reliability,
                    AmountOfEnhancements = item.AmountOfEnhancements,
                    Stiffness = item.Stiffness,
                    ItemOriginType = item.ItemOriginType,
                    ImageFileName = item.ImageFileName,

                }).ToListAsync();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = armors
            };

            return responce;
        }

        public async Task<ItemBaseResponce?> GetByIdAsync(int id)
        {
            var armor = _dbContext.Armors.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
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
                    ItemType = (int)ItemEntityType.Armor,
                    Type = item.Type,
                    EquipmentType = item.EquipmentType,
                    Reliability = item.Reliability,
                    AmountOfEnhancements = item.AmountOfEnhancements,
                    Stiffness = item.Stiffness,
                    ItemOriginType = item.ItemOriginType,
                    ImageFileName = item.ImageFileName,

                }).FirstOrDefault();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = new List<ItemBaseInfo>() { armor },
            };

            return responce;
        }

        public virtual async Task<bool> CreateAsync(ArmorRequest request)
        {
            Armor newAlchemicalItem = new Armor()
            {
                AvailabilityType = request.AvailabilityType,
                Description = request.Description,
                Id = request.Id,
                ItemType = (ItemType)ItemEntityType.Armor,
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
                EquipmentType = request.EquipmentType,
                Reliability = request.Reliability,
                AmountOfEnhancements = request.AmountOfEnhancements,
                Stiffness = request.Stiffness,
                ItemOriginType = request.ItemOriginType,
                ImageFileName = request.ImageFileName,
            };

            await _dbContext.Armors.AddAsync(newAlchemicalItem);
            return await SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(ArmorRequest request)
        {
            var armor = _dbContext.Armors.Where(x => x.Id == request.Id).FirstOrDefault();
            if (armor is null)
                throw new CustomException("Алхимический предмет не не найден!");

            armor.Name = request.Name;
            armor.UpdateDate = DateTime.Now;
            armor.Weight = request.Weight;
            armor.Price = request.Price;
            armor.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            armor.Description = request.Description;
            armor.AvailabilityType = request.AvailabilityType;
            armor.EquipmentType = request.EquipmentType;
            armor.Reliability = request.Reliability;
            armor.AmountOfEnhancements = request.AmountOfEnhancements;
            armor.Stiffness = request.Stiffness;
            armor.ItemOriginType = request.ItemOriginType;
            armor.ImageFileName = request.ImageFileName;

            var tbeList = await _dbContext.ItemBaseEffectList.Where(x => x.ItemBaseId == armor.Id).ToListAsync();
            _dbContext.RemoveRange(tbeList);

            armor.ItemBaseEffectList = request.ItemBaseEffectList.Select(dto => new ItemBaseEffectList
            {
                Id = dto.Id ?? 0,
                ItemBaseId = armor.Id,
                ChancePercent = dto.ChancePercent,
                Damage = dto.Damage,
                EffectId = dto.Effect?.Id ?? 0,
                IsDealDamage = dto.IsDealDamage,
            }).ToList();

            _dbContext.Entry(armor).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var armor = await _dbContext.Armors.Include(x => x.ItemBaseEffectList).Where(x => x.Id == id).FirstOrDefaultAsync();
            if (armor is null)
                throw new CustomException("Алхимический предмет не найден");

            armor.ItemBaseEffectList = new List<ItemBaseEffectList>();

            _dbContext.Remove(armor);
            return await SaveAsync();
        }
    }
}
