enum ItemEntityType {
  BaseItem = 1,
  Tool = 2,
  AlchemicalItem = 3,
  Armor = 4,
  Weapon = 5,
  Formula = 6,
  Blueprint = 7,
  Component = 8,
  Item = 9,
}

enum ItemAvailabilityType {
  None = 0,
  Everywhere = 1,
  Common = 2,
  Poor = 3,
  Rare = 4,
}

enum ItemOriginType {
  Human = 1,
  ElderFolk = 2,
  WitcherGear = 3,
  Relic = 4,
}

enum ItemStealthType {
  CantHide = 1,
  Large = 2,
  Small = 3,
  Tiny = 4,
}

enum ArmorType {
  Light = 1,
  Medium = 2,
  Heavy = 3,
}

enum ArmorEquipmentType {
  None = 0,
  Head = 1,
  Body = 2,
  Legs = 3,
  Shields = 4,
  Witcher = 5,
}

enum WeaponEquipmentType {
  None = 0,
  Swords = 1,
  SmallBlades = 2,
  Axes = 3,
  Bludgeoning = 4,
  Spears = 5,
  Staffs = 6,
  Thowables = 7,
  Bows = 8,
  Crossbows = 9,
  Ammunition = 10,
}

enum ItemType {
  None = 0,
}

enum SubstanceType {
  Aer = 1,
  Hydragenium = 2,
  Quebrith = 3,
  Vermilion = 4,
  Vitriol = 5,
  Rebis = 6,
  Sol = 7,
  Fulgur = 8,
  Aether = 9,
}

enum WhereToFindEnum {
  Caves = "Пещеры",
  Cities = "Города",
  ImpTerritory = "Территория бесов или бесы",
  Fields = "Поля",
  Forests = "Леса",
  Mountains = "Горы",
  Underground = "Под землей",
  BlueMountains = "Синие горы",
  EndriagNests = "Гнезда эндриаг",
  OceanFloor = "Дно океана",
  Coastline = "Побережье",
  Swamps = "Болота",
  Buy = "Покупается",
  Craft = "Изготавливается",
}

export {
  ItemEntityType,
  ItemAvailabilityType,
  ItemOriginType,
  ItemStealthType,
  ArmorType,
  SubstanceType,
  ArmorEquipmentType,
  WeaponEquipmentType,
  WhereToFindEnum,
};
