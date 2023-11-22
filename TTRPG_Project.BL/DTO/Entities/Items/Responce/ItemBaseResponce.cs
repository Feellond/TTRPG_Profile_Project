using TTRPG_Project.BL.DTO.Base;
using TTRPG_Project.BL.DTO.Creatures;
using TTRPG_Project.BL.DTO.Items;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Entities.Items.Responce
{
    public class ItemBaseResponce : BaseItemDTO
    {
        public int? Reliability { get; set; }
        public int? AmountOfEnhancements { get; set; }
        public int? Stiffness { get; set; }
        public int? Blueprint_Complexity { get; set; }
        public float? Blueprint_TimeSpend { get; set; }
        public int? Blueprint_AdditionalPayment { get; set; }
        public string WhereToFind { get; set; } = string.Empty;
        public int? Amount { get; set; }
        public int? Component_Complexity { get; set; }
        public bool? IsAlchemical { get; set; }
        public int? SubstanceType { get; set; }
        public int? Complexity { get; set; }
        public float? TimeSpend { get; set; }
        public int? AdditionalPayment { get; set; }
        public int? StealthType { get; set; }
        public int? Type { get; set; }
        public int? Accuracy { get; set; }
        public string Damage { get; set; } = string.Empty;
        public int? Weapon_Reliability { get; set; }
        public int? Grip { get; set; }
        public int? Distance { get; set; }
        public int? Weapon_StealthType { get; set; }
        public int? Weapon_AmountOfEnhancements { get; set; }
        public bool? IsAmmunition { get; set; }
        public int? SkillId { get; set; }
        public List<FormulaComponentList>? FormulaComponentLists { get; set; }
        public List<BlueprintComponentList>? BlueprintComponentLists { get; set; }
        public List<ItemBaseEffectList> ItemBaseEffectLists { get; set; } = new();
        public List<CreatureRewardList> CreatureRewardLists { get; set; } = new();
        public Skill? Skill { get; set; }
        public int ItemType { get; set; }

        public ItemBaseResponce(AlchemicalItem alchemicalItem)
        {
            Id = alchemicalItem.Id;
            Name = alchemicalItem.Name;
            Description = alchemicalItem.Description;
            Price = alchemicalItem.Price;
            Source = alchemicalItem.Source.Name;
            AvailabilityType = alchemicalItem.AvailabilityType;
            ItemBaseEffectLists = alchemicalItem.ItemBaseEffectLists;
            CreatureRewardLists = alchemicalItem.CreatureRewardLists;
            Weight = alchemicalItem.Weight;
            ItemType = (int)TTRPG_Project.DAL.Const.ItemType.AlchemicalItem;

            // И так далее для всех полей из класса Armor
        }

        public ItemBaseResponce(Armor armor)
        {
            Id = armor.Id;
            Name = armor.Name;
            Description = armor.Description;
            Price = armor.Price;
            Source = armor.Source.Name;
            AvailabilityType = armor.AvailabilityType;
            ItemBaseEffectLists = armor.ItemBaseEffectLists;
            CreatureRewardLists = armor.CreatureRewardLists;
            Weight = armor.Weight;
            ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Armor;
            // И так далее для всех полей из класса Armor
        }

        public ItemBaseResponce(Blueprint blueprint)
        {
            Id = blueprint.Id;
            Name = blueprint.Name;
            Description = blueprint.Description;
            Price = blueprint.Price;
            Source = blueprint.Source.Name;
            AvailabilityType = blueprint.AvailabilityType;
            ItemBaseEffectLists = blueprint.ItemBaseEffectLists;
            CreatureRewardLists = blueprint.CreatureRewardLists;
            Weight = blueprint.Weight;
            ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Blueprint;
            // И так далее для всех полей из класса Blueprint
        }

        public ItemBaseResponce(Component component)
        {
            Id = component.Id;
            Name = component.Name;
            Description = component.Description;
            Price = component.Price;
            Source = component.Source.Name;
            AvailabilityType = component.AvailabilityType;
            ItemBaseEffectLists = component.ItemBaseEffectLists;
            CreatureRewardLists = component.CreatureRewardLists;
            Weight = component.Weight;
            ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Component;
            // И так далее для всех полей из класса Blueprint
        }

        public ItemBaseResponce(Formula formula)
        {
            Id = formula.Id;
            Name = formula.Name;
            Description = formula.Description;
            Price = formula.Price;
            Source = formula.Source.Name;
            AvailabilityType = formula.AvailabilityType;
            ItemBaseEffectLists = formula.ItemBaseEffectLists;
            CreatureRewardLists = formula.CreatureRewardLists;
            Weight = formula.Weight;
            ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Formula;
            // И так далее для всех полей из класса Blueprint
        }

        public ItemBaseResponce(Item item)
        {
            Id = item.Id;
            Name = item.Name;
            Description = item.Description;
            Price = item.Price;
            Source = item.Source.Name;
            AvailabilityType = item.AvailabilityType;
            ItemBaseEffectLists = item.ItemBaseEffectLists;
            CreatureRewardLists = item.CreatureRewardLists;
            Weight = item.Weight;
            ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Item;
            // И так далее для всех полей из класса Blueprint
        }

        public ItemBaseResponce(Tool tool)
        {
            Id = tool.Id;
            Name = tool.Name;
            Description = tool.Description;
            Price = tool.Price;
            Source = tool.Source.Name;
            AvailabilityType = tool.AvailabilityType;
            ItemBaseEffectLists = tool.ItemBaseEffectLists;
            CreatureRewardLists = tool.CreatureRewardLists;
            Weight = tool.Weight;
            ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Tool;
            // И так далее для всех полей из класса Blueprint
        }

        public ItemBaseResponce(Weapon weapon)
        {
            Id = weapon.Id;
            Name = weapon.Name;
            Description = weapon.Description;
            Price = weapon.Price;
            Source = weapon.Source.Name;
            AvailabilityType = weapon.AvailabilityType;
            ItemBaseEffectLists = weapon.ItemBaseEffectLists;
            CreatureRewardLists = weapon.CreatureRewardLists;
            Weight = weapon.Weight;
            ItemType = (int)TTRPG_Project.DAL.Const.ItemType.Weapon;
            // И так далее для всех полей из класса Blueprint
        }
    }
}
