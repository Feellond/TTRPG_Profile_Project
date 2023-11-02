enum ItemType {
  BaseItem = 1,
  Tools = 2,
  AlchemicalItem = 3,
  Armor = 4,
  Weapon = 5,
  Formula = 6,
  Blueprint = 7,
  Component = 8,
}

enum ItemAvailabilityType {
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

export {ItemType, ItemAvailabilityType, ItemOriginType, ItemStealthType, ArmorType, SubstanceType}