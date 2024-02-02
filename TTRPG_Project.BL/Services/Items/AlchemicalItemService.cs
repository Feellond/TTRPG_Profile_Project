using Microsoft.EntityFrameworkCore;
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

        public async Task<List<ItemBaseResponce>> GetAllAsync()
        {
            var alcItems = await _dbContext.AlchemicalItems.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                .Select(item => new ItemBaseResponce
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = (item.Source != null ? item.Source.Name : ""),
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectList = item.ItemBaseEffectList,
                    ItemType = (int)ItemEntityType.AlchemicalItem,
                }).ToListAsync();

            return alcItems;
        }

        public async Task<ItemBaseResponce?> GetByIdAsync(int id)
        {
            var alcItem = _dbContext.AlchemicalItems.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                .Select(item => new ItemBaseResponce
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = (item.Source != null ? item.Source.Name : ""),
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectList = item.ItemBaseEffectList,
                    ItemType = (int)ItemEntityType.AlchemicalItem,
                }).FirstOrDefault();

            return alcItem;
        }

        public virtual async Task<bool> CreateAsync(AlchemicalItemRequest request)
        {
            AlchemicalItem newAlchemicalItem = new AlchemicalItem()
            {
                AvailabilityType = request.AvailabilityType,
                Description = request.Description,
                Id = request.Id,
                ItemType = (ItemType)ItemEntityType.AlchemicalItem,
                ItemBaseEffectList = request.ItemBaseEffectList.Select(dto => new ItemBaseEffectList
                {
                    ChancePercent = dto.ChancePercent,
                    Damage = dto.Damage,
                    EffectId = dto.Effect?.Id ?? 0,
                    IsDealDamage = dto.IsDealDamage,
                }).ToList(),
                Name = request.Name,
                Price = request.Price,
                SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).First().Id,
                Weight = request.Weight,
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
            alcItem.SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).First().Id;
            alcItem.Description = request.Description;
            alcItem.AvailabilityType = request.AvailabilityType;

            var tbeList = await _dbContext.ItemBaseEffectList.Where(x => x.ItemBaseId == alcItem.Id).ToListAsync();
            _dbContext.RemoveRange(tbeList);

            alcItem.ItemBaseEffectList = request.ItemBaseEffectList.Select(dto => new ItemBaseEffectList
            {
                Id = dto.Id ?? 0,
                ItemBaseId = alcItem.Id,
                ChancePercent = dto.ChancePercent,
                Damage = dto.Damage,
                EffectId = dto.Effect?.Id ?? 0,
                IsDealDamage = dto.IsDealDamage,
            }).ToList();

            _dbContext.Entry(alcItem).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var alcItem = await _dbContext.AlchemicalItems.FindAsync(id);
            if (alcItem is null)
                throw new CustomException("Алхимический предмет не найден");

            _dbContext.Remove(alcItem);
            return await SaveAsync();
        }
    }
}
