using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        //public async Task<IActionResult> GetAllAsync()
        //{
        //    //var itemBaseData = _dbContext.ItemBases.AsNoTracking().Select(itemBase => itemBase switch
        //    //{
        //    //    Blueprint blueprint => new ItemBaseResponce
        //    //    {
        //    //        ItemType = (int)ItemType.Blueprint,
        //    //        AvailabilityType = blueprint.AvailabilityType,
        //    //        Weight = blueprint.Weight,
        //    //        Price = blueprint.Price,
        //    //        // Добавьте другие поля, специфичные для Blueprint
        //    //    },
        //    //    Formula formula => new ItemBaseResponce
        //    //    {
        //    //        ItemType = (int)ItemType.Formula,
        //    //        AvailabilityType = formula.AvailabilityType,
        //    //        Weight = formula.Weight,
        //    //        Price = formula.Price,
        //    //        // Добавьте другие поля, специфичные для Formula
        //    //    },
        //    //    AlchemicalItem alchemicalItem => new ItemBaseResponce
        //    //    {
        //    //        ItemType = (int)ItemType.AlchemicalItem,
        //    //        AvailabilityType = alchemicalItem.AvailabilityType,
        //    //        Weight = alchemicalItem.Weight,
        //    //        Price = alchemicalItem.Price,
        //    //        // Добавьте другие поля, специфичные для AlchemicalItem
        //    //    },
        //    //    Armor armor => new ItemBaseResponce
        //    //    {
        //    //        ItemType = (int)ItemType.Armor,
        //    //        AvailabilityType = armor.AvailabilityType,
        //    //        Weight = armor.Weight,
        //    //        Price = armor.Price,
        //    //        // Добавьте другие поля, специфичные для Armor
        //    //        Reliability = armor.Reliability,
        //    //        AmountOfEnhancements = armor.AmountOfEnhancements,
        //    //        Stiffness = armor.Stiffness
        //    //    },
        //    //    Component component => new ItemBaseResponce
        //    //    {
        //    //        ItemType = (int)ItemType.Component,
        //    //        AvailabilityType = component.AvailabilityType,
        //    //        Weight = component.Weight,
        //    //        Price = component.Price,
        //    //        // Добавьте другие поля, специфичные для Component
        //    //        WhereToFind = component.WhereToFind,
        //    //        Amount = component.Amount,
        //    //        Complexity = component.Complexity,
        //    //        IsAlchemical = component.IsAlchemical,
        //    //        SubstanceType = component.SubstanceType,
        //    //        FormulaComponentLists = component.FormulaComponentLists,
        //    //        BlueprintComponentLists = component.BlueprintComponentLists
        //    //    },
        //    //    Item item => new ItemBaseResponce
        //    //    {
        //    //        ItemType = (int)ItemType.BaseItem,
        //    //        AvailabilityType = item.AvailabilityType,
        //    //        Weight = item.Weight,
        //    //        Price = item.Price,
        //    //        // Добавьте другие поля, специфичные для Item
        //    //        StealthType = item.StealthType,
        //    //        Type = item.Type
        //    //    },
        //    //    Tool tool => new ItemBaseResponce
        //    //    {
        //    //        ItemType = (int)ItemType.Tool,
        //    //        AvailabilityType = tool.AvailabilityType,
        //    //        Weight = tool.Weight,
        //    //        Price = tool.Price,
        //    //        // Добавьте другие поля, специфичные для Tool
        //    //    },
        //    //    Weapon weapon => new ItemBaseResponce
        //    //    {
        //    //        ItemType = (int)ItemType.Weapon,
        //    //        AvailabilityType = weapon.AvailabilityType,
        //    //        Weight = weapon.Weight,
        //    //        Price = weapon.Price,
        //    //        // Добавьте другие поля, специфичные для Weapon
        //    //        Accuracy = weapon.Accuracy,
        //    //        Damage = weapon.Damage,
        //    //        Reliability = weapon.Reliability,
        //    //        Grip = weapon.Grip,
        //    //        Distance = weapon.Distance,
        //    //        StealthType = weapon.StealthType,
        //    //        AmountOfEnhancements = weapon.AmountOfEnhancements,
        //    //        IsAmmunition = weapon.IsAmmunition,
        //    //        SkillId = weapon.SkillId,
        //    //        Skill = weapon.Skill
        //    //    },
        //    //    // Добавьте другие варианты для остальных типов
        //    //    _ => new ItemBaseResponce
        //    //    {
        //    //        ItemType = (int)ItemType.BaseItem,
        //    //        AvailabilityType = itemBase.AvailabilityType,
        //    //        Weight = itemBase.Weight,
        //    //        Price = itemBase.Price
        //    //        // Добавьте другие общие поля для всех наследников ItemBase
        //    //    }
        //    //}).ToList();

        //    return itemBaseData;
        //}
    }
}
