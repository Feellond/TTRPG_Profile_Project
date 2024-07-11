using IdentityModel;
using Microsoft.EntityFrameworkCore;
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
    public class ItemService : BaseService<Item, int>
    {
        public ItemService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<ItemBaseResponce> GetAllAsync()
        {
            var items = await _dbContext.Items.AsNoTracking()
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
                    ItemType = (int)ItemEntityType.Item,
                    StealthType = item.StealthType,
                    Type = item.Type,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = items,
            };

            return responce;
        }

        public async Task<ItemBaseResponce?> GetByIdAsync(int id)
        {
            var item = _dbContext.Items.AsNoTracking()
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
                    ItemType = (int)ItemEntityType.Item,
                    StealthType = item.StealthType,
                    Type = item.Type,
                    ImageFileName = item.ImageFileName,
                }).FirstOrDefault();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = new List<ItemBaseInfo>() { item },
            };

            return responce;
        }

        public virtual async Task<bool> CreateAsync(ItemRequest request)
        {
            Item newItem = new Item()
            {
                AvailabilityType = request.AvailabilityType,
                Description = request.Description,
                Id = request.Id,
                ItemType = (ItemType)ItemEntityType.Item,
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
                ImageFileName = request.ImageFileName,
            };

            await _dbContext.Items.AddAsync(newItem);
            return await SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(ItemRequest request)
        {
            var item = _dbContext.Items.Where(x => x.Id == request.Id).FirstOrDefault();
            if (item is null)
                throw new CustomException("Предмет не не найден!");

            item.Name = request.Name;
            item.UpdateDate = DateTime.Now;
            item.Weight = request.Weight;
            item.Price = request.Price;
            item.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            item.Description = request.Description;
            item.AvailabilityType = request.AvailabilityType;
            item.StealthType = request.StealthType; 
            item.Type = request.Type;
            item.ImageFileName = request.ImageFileName;

            var tbeList = await _dbContext.ItemBaseEffectList.Where(x => x.ItemBaseId == item.Id).ToListAsync();
            _dbContext.RemoveRange(tbeList);

            item.ItemBaseEffectList = request.ItemBaseEffectList?.Select(dto => new ItemBaseEffectList
            {
                Id = dto.Id ?? 0,
                ItemBaseId = item.Id,
                ChancePercent = dto.ChancePercent,
                Damage = dto.Damage,
                EffectId = dto.Effect?.Id ?? 0,
                IsDealDamage = dto.IsDealDamage,
            }).ToList() ?? new List<ItemBaseEffectList>();

            _dbContext.Entry(item).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var item = await _dbContext.Items.FindAsync(id);
            if (item is null)
                throw new CustomException("Предмет не найден");

            _dbContext.Remove(item);
            return await SaveAsync();
        }
    }
}
