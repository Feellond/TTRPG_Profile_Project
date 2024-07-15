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
    public class AlchemicalItemService : BaseService<AlchemicalItem, int>
    {
        public AlchemicalItemService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<ItemBaseResponce> GetAllAsync()
        {
            var alcItems = await _dbContext.AlchemicalItems.AsNoTracking()
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
                    ItemType = (int)ItemEntityType.AlchemicalItem,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            ItemBaseResponce responce = new()
            {
                Count = alcItems.Count,
                Entitys = alcItems,
            };

            return responce;
        }

        public async Task<ItemBaseResponce?> GetByIdAsync(int id)
        {
            var alcItem = _dbContext.AlchemicalItems.AsNoTracking()
                .Where(x => x.Id == id)
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
                    ItemType = (int)ItemEntityType.AlchemicalItem,
                    ImageFileName = item.ImageFileName,
                }).FirstOrDefault();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = new List<ItemBaseInfo>() { alcItem },
            };

            return responce;
        }

        public virtual async Task<bool> CreateAsync(AlchemicalItemRequest request)
        {
            AlchemicalItem newAlchemicalItem = new AlchemicalItem()
            {
                AvailabilityType = request.AvailabilityType,
                Description = request.Description,
                Id = request.Id,
                ItemType = (ItemType)ItemEntityType.AlchemicalItem,
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
                ImageFileName = request.ImageFileName,
            };

            await _dbContext.AlchemicalItems.AddAsync(newAlchemicalItem);
            return await SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(AlchemicalItemRequest request)
        {
            var alcItem = _dbContext.AlchemicalItems.Where(x => x.Id == request.Id).FirstOrDefault();
            if (alcItem is null)
                throw new CustomException("Алхимический предмет не не найден!");

            alcItem.Name = request.Name;
            alcItem.UpdateDate = DateTime.Now;
            alcItem.Weight = request.Weight;
            alcItem.Price = request.Price;
            alcItem.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            alcItem.Description = request.Description;
            alcItem.AvailabilityType = request.AvailabilityType;
            alcItem.ImageFileName = request.ImageFileName;

            var tbeList = await _dbContext.ItemBaseEffectList.Where(x => x.ItemBaseId == alcItem.Id).ToListAsync();
            _dbContext.RemoveRange(tbeList);

            alcItem.ItemBaseEffectList = request.ItemBaseEffectList?.Select(dto => new ItemBaseEffectList
            {
                Id = dto.Id ?? 0,
                ItemBaseId = alcItem.Id,
                ChancePercent = dto.ChancePercent,
                Damage = dto.Damage,
                EffectId = dto.Effect?.Id ?? 0,
                IsDealDamage = dto.IsDealDamage,
            }).ToList() ?? new List<ItemBaseEffectList>();

            _dbContext.Entry(alcItem).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var alcItem = await _dbContext.AlchemicalItems.Include(x => x.ItemBaseEffectList).Where(x => x.Id == id).FirstOrDefaultAsync();
            if (alcItem is null)
                throw new CustomException("Алхимический предмет не найден");

            alcItem.ItemBaseEffectList = new List<ItemBaseEffectList>();

            _dbContext.Remove(alcItem);
            return await SaveAsync();
        }
    }
}
