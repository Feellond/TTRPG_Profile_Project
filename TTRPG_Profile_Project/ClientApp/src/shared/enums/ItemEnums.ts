enum ItemEntityType {
  //BaseItem = 1,
  Tool = 2,
  AlchemicalItem = 3,
  Armor = 4,
  Weapon = 5,
  Formula = 6,
  Blueprint = 7,
  Item = 8,
  ComponentRem = 9, //Все компоненты
  ComponentAlc = 10,//Заглушка для фронтенда
}

enum ItemAvailabilityType {
  Everywhere = 1,
  Common = 2,
  Poor = 3,
  Rare = 4,
  None = 5,
}

enum ItemOriginType {
  Human = 1,
  ElderFolk = 2,
  WitcherGear = 3,
  Relic = 4,
}

enum ItemStealthType {
  CantHide = 1,
  Tiny = 2,
  Small = 3,
  Large = 4,
}

enum ArmorType {
  Light = 1,
  Medium = 2,
  Heavy = 3,
}

enum ArmorEquipmentType {
  Head = 1,
  Body = 2,
  Legs = 3,
  Shields = 4,
  Witcher = 5,
  None = 6,
}

enum WeaponEquipmentType {
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
  None = 11,
}

enum SubstanceType {
  Caelum = 1, //Аэр
  Hydragenium = 2, //Гидраген
  Quebrith = 3, //Квебрит
  Vermilion = 4,  //Киноварь
  Vitriol = 5,  //Купорос
  Rebis = 6,  //Рэбис
  Sol = 7,    //Солнце
  Fulgur = 8, //Фульгор
  Aether = 9, //Эфир
}

enum WhereToFindEnum {
  Caves = "Пещеры",
  Cities = "Города",
  Imps = "Бесы",
  ImpTerritory = "Территория бесов",
  Mages = "Маги",
  PowerPlace = "Места силы",
  Fields = "Поля",
  Plantations = "Плантации",
  Forests = "Леса",
  Mountains = "Горы",
  Underground = "Под землей",
  BlueMountains = "Синие горы",
  EndriagNests = "Гнезда эндриаг",
  OceanFloor = "Дно океана",
  Rivers = "Реки",
  RiversCoast = "Берега реки",
  Coastline = "Побережье",
  Swamps = "Болота",
  Buy = "Покупается",
  Craft = "Изготавливается",
  Anywhere = "Где угодно на поверхности земли",
  Everywhere = "Где угодно",
  Campfire = "Костер",
  Burned = "Сгоревшие предметы",
  Monsters = "Чудовища",
  Animals = "Животные",
  Birds = "Птицы",
  Wolfs = "Волки",
  Wyverns = "Виверны"
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
