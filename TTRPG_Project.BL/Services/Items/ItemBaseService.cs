using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Drawing.Printing;
using System.Linq;
using TTRPG_Project.BL.DTO.Entities.Items;
using TTRPG_Project.BL.DTO.Entities.Items.Responce;
using TTRPG_Project.BL.DTO.Filters;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Items;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TTRPG_Project.BL.Services.Items
{
    public class ItemBaseService : BaseService<ItemBase, int>
    {
        public ItemBaseService(ApplicationDbContext dbContext) : base(dbContext)
        {
        
        }

        public async Task<ItemBaseResponce> GetAllAsync(ItemFilter filter)
        {
            var alchemicalItems = await _dbContext.AlchemicalItems.AsNoTracking()
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
                    Reliability = item.Reliability,
                    AmountOfEnhancements = item.AmountOfEnhancements,
                    Stiffness = item.Stiffness,
                    ItemOriginType = item.ItemOriginType,
                    Type = item.Type,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            var blueprints = await _dbContext.Blueprints.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Include(bcl => bcl.BlueprintComponentList)
                    .ThenInclude(c => c.Component)
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
                    ItemType = (int)ItemEntityType.Blueprint,
                    Complexity = item.Complexity,
                    TimeSpend = item.TimeSpend,
                    AdditionalPayment = item.AdditionalPayment,
                    BlueprintComponentList = item.BlueprintComponentList,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            var components = await _dbContext.Components.AsNoTracking()
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
                    ItemType = (int)ItemEntityType.Component,
                    WhereToFind = item.WhereToFind,
                    Amount = item.Amount,
                    Complexity = item.Complexity,
                    IsAlchemical = item.IsAlchemical,
                    SubstanceType = item.SubstanceType,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            var formulas = await _dbContext.Formulas.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Include(fcl => fcl.FormulaSubstanceList)
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
                    ItemType = (int)ItemEntityType.Formula,
                    Complexity = item.Complexity,
                    TimeSpend = item.TimeSpend,
                    AdditionalPayment = item.AdditionalPayment,
                    FormulaSubstanceList = item.FormulaSubstanceList,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

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

            var tools = await _dbContext.Tools.AsNoTracking()
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
                    ItemType = (int)ItemEntityType.Tool,
                    StealthType = item.StealthType,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            var weapons = await _dbContext.Weapons.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectList)
                    .ThenInclude(eff => eff.Effect)
                        .ThenInclude(s => s.Source)
                .Include(s => s.Skill)
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
                    ItemType = (int)ItemEntityType.Weapon,
                    Accuracy = item.Accuracy,
                    Damage = item.Damage,
                    Reliability = item.Reliability,
                    Grip = item.Grip,
                    Distance = item.Distance,
                    StealthType = item.StealthType,
                    AmountOfEnhancements = item.AmountOfEnhancements,
                    IsAmmunition = item.IsAmmunition,
                    Skill = item.Skill,
                    ImageFileName = item.ImageFileName,
                }).ToListAsync();

            var allItemsQuery = alchemicalItems
                .Union(armors)
                .Union(blueprints)
                .Union(components)
                .Union(formulas)
                .Union(items)
                .Union(tools)
                .Union(weapons).ToList();

            foreach (var item in filter.whereExpression)
            {
                var compiledExpression = item.Compile();
                allItemsQuery = allItemsQuery.Where(compiledExpression).ToList();
            }

            //var skip = (filter.Page - 1) * filter.PageSize;
            var count = allItemsQuery.Count();
            var allItems = allItemsQuery.OrderBy(x => x.Name).Skip(filter.First).Take(filter.PageSize).ToList();
            ItemBaseResponce responce = new()
            {
                Count = count,
                Entitys = allItems,
            };

            return responce;
        }

        public async Task<ItemBaseShortResponce> GetAllSimpleAsync()
        {
            var baseItems = await _dbContext.ItemBases.AsNoTracking().ToListAsync();

            var count = baseItems.Count();
            ItemBaseShortResponce responce = new()
            {
                Count = count,
                Entitys = baseItems,
            };

            return responce;
        }
    }
}
