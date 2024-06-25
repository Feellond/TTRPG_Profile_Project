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
    public class BlueprintService : BaseService<Blueprint, int>
    {
        public BlueprintService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<ItemBaseResponce> GetAllAsync()
        {
            var blueprints = await _dbContext.Blueprints.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Include(fcl => fcl.BlueprintComponentList)
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
                    ItemType = (int)ItemEntityType.Blueprint,
                    Complexity = item.Complexity,
                    TimeSpend = item.TimeSpend,
                    AdditionalPayment = item.AdditionalPayment,
                    BlueprintComponentList = item.BlueprintComponentList,
                }).ToListAsync();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = blueprints,
            };

            return responce;
        }

        public async Task<ItemBaseResponce?> GetByIdAsync(int id)
        {
            var blueprint = _dbContext.Blueprints.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Include(fcl => fcl.BlueprintComponentList)
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
                    ItemType = (int)ItemEntityType.Blueprint,
                    Complexity = item.Complexity,
                    TimeSpend = item.TimeSpend,
                    AdditionalPayment = item.AdditionalPayment,
                    BlueprintComponentList = item.BlueprintComponentList,
                }).FirstOrDefault();

            ItemBaseResponce responce = new()
            {
                Count = 1,
                Entitys = new List<ItemBaseInfo>() { blueprint },
            };

            return responce;
        }

        public virtual async Task<bool> CreateAsync(BlueprintRequest request)
        {
            Blueprint newBlueprint = new Blueprint()
            {
                AdditionalPayment = request.AdditionalPayment,
                AvailabilityType = request.AvailabilityType,
                Complexity = request.Complexity,
                Description = request.Description,
                BlueprintComponentList = request.BlueprintComponentList?.Select(dto => new BlueprintComponentList
                {
                    ComponentId = dto.Component?.Id ?? 0,
                    Amount = dto.Amount,
                }).ToList() ?? new List<BlueprintComponentList>(),
                Id = request.Id,
                ItemType = (ItemType)ItemEntityType.Blueprint,
                Name = request.Name,
                Price = request.Price,
                SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2,
                TimeSpend = request.TimeSpend,
                Weight = request.Weight,
            };

            await _dbContext.Blueprints.AddAsync(newBlueprint);
            return await SaveAsync();
        }

        public virtual async Task<bool> UpdateAsync(BlueprintRequest request)
        {
            var blueprint = _dbContext.Blueprints.Where(x => x.Id == request.Id).FirstOrDefault();
            if (blueprint is null)
                throw new Exception("Чертеж не найден!");

            blueprint.UpdateDate = DateTime.Now;
            blueprint.TimeSpend = request.TimeSpend;
            blueprint.Weight = request.Weight;
            blueprint.Price = request.Price;
            blueprint.SourceId = _dbContext.Sources.Where(x => x.Name == (request.Source == null ? "Хоумбрю" : request.Source.Name)).FirstOrDefault()?.Id ?? 2;
            blueprint.AdditionalPayment = request.AdditionalPayment;
            blueprint.Complexity = request.Complexity;
            blueprint.Description = request.Description;
            blueprint.AvailabilityType = request.AvailabilityType;

            var bcList = await _dbContext.BlueprintComponentList.Where(x => x.BlueprintId == blueprint.Id).ToListAsync();
            _dbContext.BlueprintComponentList.RemoveRange(bcList);

            blueprint.BlueprintComponentList = request.BlueprintComponentList?
                .Where(x => x.Component != null)
                .Select(dto => new BlueprintComponentList
            {
                Id = dto.Id ?? 0,
                BlueprintId = blueprint.Id,
                ComponentId = dto.Component.Id,
                Amount = dto.Amount,
            }).ToList() ?? new List<BlueprintComponentList>();

            _dbContext.Entry(blueprint).State = EntityState.Modified;
            return await SaveAsync();
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var blueprint = await _dbContext.Blueprints.FindAsync(id);
            if (blueprint is null)
                throw new CustomException("Чертеж не найден");

            _dbContext.Remove(blueprint);
            return await SaveAsync();
        }
    }
}
