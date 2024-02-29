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
    public class ComponentService : BaseService<Component, int>
    {
        public ComponentService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<ItemBaseResponce> GetAllAsync()
        {
            var components = await _dbContext.Components.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
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
                    ItemType = (int)ItemEntityType.Component,
                    WhereToFind = item.WhereToFind,
                    Amount = item.Amount,
                    Complexity = item.Complexity,
                    IsAlchemical = item.IsAlchemical,
                    SubstanceType = item.SubstanceType,
                }).ToListAsync();

            ItemBaseResponce responce = new()
            {
                Count = components.Count,
                Items = components,
            };

            return responce;
        }

        public async Task<ItemBaseResponce?> GetByIdAsync(int id)
        {
            var component = _dbContext.Components.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
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
                    ItemType = (int)ItemEntityType.Component,
                    WhereToFind = item.WhereToFind,
                    Amount = item.Amount,
                    Complexity = item.Complexity,
                    IsAlchemical = item.IsAlchemical,
                    SubstanceType = item.SubstanceType,
                }).FirstOrDefault();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Items = new List<ItemBaseInfo>() { component },
            };

            return responce;
        }

        public virtual async Task<bool> CreateAsync(ComponentRequest request)
        {
            Component newComponent = new Component()
            {
                AvailabilityType = request.AvailabilityType,
                Description = request.Description,
                Id = request.Id,
                ItemType = (ItemType)ItemEntityType.Component,
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
                WhereToFind = request.WhereToFind,
                Amount = request.Amount,
                Complexity = request.Complexity,
                IsAlchemical = request.IsAlchemical,
                SubstanceType = request.SubstanceType,
            };

            await _dbContext.Components.AddAsync(newComponent);
            return await SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(ComponentRequest request)
        {
            var component = _dbContext.Components.Where(x => x.Id == request.Id).FirstOrDefault();
            if (component is null)
                throw new CustomException("Алхимический предмет не не найден!");

            component.Name = request.Name;
            component.UpdateDate = DateTime.Now;
            component.Weight = request.Weight;
            component.Price = request.Price;
            component.SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2;
            component.Description = request.Description;
            component.AvailabilityType = request.AvailabilityType;
            component.WhereToFind = request.WhereToFind;
            component.Amount = request.Amount;
            component.Complexity = request.Complexity;
            component.IsAlchemical = request.IsAlchemical;
            component.SubstanceType = request.SubstanceType;

            var tbeList = await _dbContext.ItemBaseEffectList.Where(x => x.ItemBaseId == component.Id).ToListAsync();
            _dbContext.RemoveRange(tbeList);

            component.ItemBaseEffectList = request.ItemBaseEffectList.Select(dto => new ItemBaseEffectList
            {
                Id = dto.Id ?? 0,
                ItemBaseId = component.Id,
                ChancePercent = dto.ChancePercent,
                Damage = dto.Damage,
                EffectId = dto.Effect?.Id ?? 0,
                IsDealDamage = dto.IsDealDamage,
            }).ToList();

            _dbContext.Entry(component).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var component = await _dbContext.Components.FindAsync(id);
            if (component is null)
                throw new CustomException("Алхимический предмет не найден");

            _dbContext.Remove(component);
            return await SaveAsync();
        }
    }
}
