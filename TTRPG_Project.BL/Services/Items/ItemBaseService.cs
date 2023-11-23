using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using TTRPG_Project.BL.DTO.Entities.Items.Responce;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.Services.Items
{
    public class ItemBaseService : BaseService<ItemBase, int>
    {
        public ItemBaseService(ApplicationDbContext dbContext) : base(dbContext)
        {
        
        }

        public new async Task<List<ItemBaseResponce>> GetAllAsync()
        {
            //var allItems = await _dbContext.AlchemicalItems.AsNoTracking()
            //    .Select(item => new ItemBaseResponce(item))
            //    .Concat(_dbContext.Armors.AsNoTracking().Select(item => new ItemBaseResponce(item)))
            //    .Concat(_dbContext.Blueprints.AsNoTracking().Select(item => new ItemBaseResponce(item)))
            //    .Concat(_dbContext.Components.AsNoTracking().Select(item => new ItemBaseResponce(item)))
            //    .Concat(_dbContext.Formulas.AsNoTracking().Select(item => new ItemBaseResponce(item)))
            //    .Concat(_dbContext.Items.AsNoTracking().Select(item => new ItemBaseResponce(item)))
            //    .Concat(_dbContext.Tools.AsNoTracking().Select(item => new ItemBaseResponce(item)))
            //    .Concat(_dbContext.Weapons.AsNoTracking().Select(item => new ItemBaseResponce(item)))
            //    .ToListAsync();

            var alchemicalItems = await _dbContext.AlchemicalItems.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectLists)
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
                    ItemBaseEffectLists = item.ItemBaseEffectLists,
                    ItemType = (int)ItemType.AlchemicalItem,
                })
                .ToListAsync();

            var armors = await _dbContext.Armors.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectLists)
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
                    ItemBaseEffectLists = item.ItemBaseEffectLists,
                    ItemType = (int)ItemType.Armor,
                    Reliability = item.Reliability,
                    AmountOfEnhancements = item.AmountOfEnhancements,
                    Stiffness = item.Stiffness,
                })
                .ToListAsync();

            var blueprints = await _dbContext.Blueprints.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectLists)
                    .ThenInclude(eff => eff.Effect)
                .Include(bcl => bcl.BlueprintComponentLists)
                    .ThenInclude(c => c.Component)
                .Select(item => new ItemBaseResponce
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = (item.Source != null ? item.Source.Name : ""),
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectLists = item.ItemBaseEffectLists,
                    ItemType = (int)ItemType.Blueprint,
                    Complexity = item.Complexity,
                    TimeSpend = item.TimeSpend,
                    AdditionalPayment = item.AdditionalPayment,
                    BlueprintComponentLists = item.BlueprintComponentLists,
                })
                .ToListAsync();

            var components = await _dbContext.Components.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectLists)
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
                    ItemBaseEffectLists = item.ItemBaseEffectLists,
                    ItemType = (int)ItemType.Component,
                    WhereToFind = item.WhereToFind,
                    Amount = item.Amount,
                    Complexity = item.Complexity,
                    IsAlchemical = item.IsAlchemical,
                    SubstanceType = item.SubstanceType,
                })
                .ToListAsync();

            var formulas = await _dbContext.Formulas.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectLists)
                    .ThenInclude(eff => eff.Effect)
                .Include(fcl => fcl.FormulaComponentLists)
                    .ThenInclude(c => c.Component)
                .Select(item => new ItemBaseResponce
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = (item.Source != null ? item.Source.Name : ""),
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectLists = item.ItemBaseEffectLists,
                    ItemType = (int)ItemType.Formula,
                    Complexity = item.Complexity,
                    TimeSpend = item.TimeSpend,
                    AdditionalPayment = item.AdditionalPayment,
                    FormulaComponentLists = item.FormulaComponentLists,
                })
                .ToListAsync();

            var items = await _dbContext.Items.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectLists)
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
                    ItemBaseEffectLists = item.ItemBaseEffectLists,
                    ItemType = (int)ItemType.Item,
                    StealthType = item.StealthType,
                    Type = item.Type,
                })
                .ToListAsync();

            var tools = await _dbContext.Tools.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectLists)
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
                    ItemBaseEffectLists = item.ItemBaseEffectLists,
                    ItemType = (int)ItemType.Tool,
                })
                .ToListAsync();

            var weapons = await _dbContext.Weapons.AsNoTracking()
                .Include(s => s.Source)
                .Include(ibe => ibe.ItemBaseEffectLists)
                    .ThenInclude(eff => eff.Effect)
                .Include(s => s.Skill)
                .Select(item => new ItemBaseResponce
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Source = (item.Source != null ? item.Source.Name : ""),
                    AvailabilityType = item.AvailabilityType,
                    Weight = item.Weight,
                    Price = item.Price,
                    ItemBaseEffectLists = item.ItemBaseEffectLists,
                    ItemType = (int)ItemType.Weapon,
                    Accuracy = item.Accuracy,
                    Damage = item.Damage,
                    Reliability = item.Reliability,
                    Grip = item.Grip,
                    Distance = item.Distance,
                    StealthType = item.StealthType,
                    AmountOfEnhancements = item.AmountOfEnhancements,
                    IsAmmunition = item.IsAmmunition,
                    Skill = item.Skill,
                })
                .ToListAsync();

            var allItems = alchemicalItems
                .Union(armors)
                .Union(blueprints)
                .Union(components)
                .Union(formulas)
                .Union(items)
                .Union(tools)
                .Union(weapons)
                .ToList();

            return allItems;
        }
    }
}
