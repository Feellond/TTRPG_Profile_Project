using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.BL.DTO.Creatures;
using TTRPG_Project.BL.DTO.Items;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Entities.Items.Responce
{
    public class ItemBaseResponce
    {
        public int Count { get; set; }
        public List<ItemBaseInfo> Entitys { get; set; }

        //public ItemBaseResponce(AlchemicalItem alchemicalItem)
        //{
        //    Id = alchemicalItem.Id;
        //    Name = alchemicalItem.Name;
        //    Description = alchemicalItem.Description;
        //    Price = alchemicalItem.Price;
        //    Source = alchemicalItem.Source?.Name ?? "";
        //    AvailabilityType = alchemicalItem.AvailabilityType;
        //    Weight = alchemicalItem.Weight;
        //    ItemType = (int)TTRPG_Project.DAL.Const.ItemType.AlchemicalItem;

        //    // И так далее для всех полей из класса Armor
        //}

        //public ItemBaseResponce(Armor armor)
        //{
        //    Id = armor.Id;
        //    Name = armor.Name;
        //    Description = armor.Description;
        //    Price = armor.Price;
        //    Source = armor.Source?.Name ?? "";
        //    AvailabilityType = armor.AvailabilityType;
        //    Weight = armor.Weight;
        //    ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Armor;
        //    // И так далее для всех полей из класса Armor
        //}

        //public ItemBaseResponce(Blueprint blueprint)
        //{
        //    Id = blueprint.Id;
        //    Name = blueprint.Name;
        //    Description = blueprint.Description;
        //    Price = blueprint.Price;
        //    Source = blueprint.Source?.Name ?? "";
        //    AvailabilityType = blueprint.AvailabilityType;
        //    Weight = blueprint.Weight;
        //    ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Blueprint;
        //    // И так далее для всех полей из класса Blueprint
        //}

        //public ItemBaseResponce(Component component)
        //{
        //    Id = component.Id;
        //    Name = component.Name;
        //    Description = component.Description;
        //    Price = component.Price;
        //    Source = component.Source?.Name ?? "";
        //    AvailabilityType = component.AvailabilityType;
        //    Weight = component.Weight;
        //    ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Component;
        //    // И так далее для всех полей из класса Blueprint
        //}

        //public ItemBaseResponce(Formula formula)
        //{
        //    Id = formula.Id;
        //    Name = formula.Name;
        //    Description = formula.Description;
        //    Price = formula.Price;
        //    Source = formula.Source?.Name ?? "";
        //    AvailabilityType = formula.AvailabilityType;
        //    Weight = formula.Weight;
        //    ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Formula;
        //    // И так далее для всех полей из класса Blueprint
        //}

        //public ItemBaseResponce(Item item)
        //{
        //    Id = item.Id;
        //    Name = item.Name;
        //    Description = item.Description;
        //    Price = item.Price;
        //    Source = item.Source?.Name ?? "";
        //    AvailabilityType = item.AvailabilityType;
        //    Weight = item.Weight;
        //    ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Item;
        //    // И так далее для всех полей из класса Blueprint
        //}

        //public ItemBaseResponce(Tool tool)
        //{
        //    Id = tool.Id;
        //    Name = tool.Name;
        //    Description = tool.Description;
        //    Price = tool.Price;
        //    Source = tool.Source?.Name ?? "";
        //    AvailabilityType = tool.AvailabilityType;
        //    Weight = tool.Weight;
        //    ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Tool;
        //    // И так далее для всех полей из класса Blueprint
        //}

        //public ItemBaseResponce(Weapon weapon)
        //{
        //    Id = weapon.Id;
        //    Name = weapon.Name;
        //    Description = weapon.Description;
        //    Price = weapon.Price;
        //    Source = weapon.Source?.Name ?? "";
        //    AvailabilityType = weapon.AvailabilityType;
        //    Weight = weapon.Weight;
        //    ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Weapon;
        //    // И так далее для всех полей из класса Blueprint
        //}
    }
}
