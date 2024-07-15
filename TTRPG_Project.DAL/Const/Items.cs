using System.ComponentModel;

namespace TTRPG_Project.DAL.Const
{
    public enum ItemEntityType
    {
        BaseItem = 1,
        Tool = 2,
        AlchemicalItem = 3,
        Armor = 4,
        Weapon = 5,
        Formula = 6,
        Blueprint = 7,
        Item = 8,
        Component = 9,
    }

    public enum ItemAvailabilityType
    {
        Everywhere = 1,
        Common = 2,
        Poor = 3,
        Rare = 4,
        None = 5,
    }

    public enum ItemOriginType
    {
        Human = 1,
        ElderFolk = 2,
        WitcherGear = 3,
        Relic = 4,
    }

    public enum ItemStealthType
    {
        /// <summary>
        /// Не спрятать (Н/С): невозможно спрятать под одеждой.
        /// </summary>
        CantHide = 1,
        /// <summary>
        /// Маленькое (М): можно спрятать в кармане.
        /// </summary>
        Tiny = 2,
        /// <summary>
        /// Небольшое (Н): можно спрятать под курткой.
        /// </summary>
        Small = 3,
        /// <summary>
        /// Крупное (К): можно спрятать под плащом.
        /// </summary>
        Large = 4,
    }

    public enum ArmorType
    {
        Light = 1,
        Medium = 2,
        Heavy = 3,
    }

    public enum ArmorEquipmentType
    {
        Head = 1,
        Body = 2,
        Legs = 3,
        Shields = 4,
        Witcher = 5,
        None = 6,
    }

    public enum WeaponEquipmentType
    {
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

    public enum ItemType
    {
        None = 0,
    }

    public enum SubstanceType
    {
        /// <summary>
        /// Аер
        /// </summary>
		Caelum = 1,
        /// <summary>
        /// Гидроген
        /// </summary>
        Hydragenium = 2,
        /// <summary>
        /// Квебрит
        /// </summary>
        Quebrith = 3,
        /// <summary>
        /// Киноварь
        /// </summary>
        Vermilion = 4,
        /// <summary>
        /// Купорос
        /// </summary>
        Vitriol = 5,
        /// <summary>
        /// Ребис
        /// </summary>
        Rebis = 6,
        /// <summary>
        /// Солнце
        /// </summary>
        Sol = 7,
        /// <summary>
        /// Фульгор
        /// </summary>
        Fulgur = 8,
        /// <summary>
        /// Эфир
        /// </summary>
        Aether = 9,
    }

    public static class WhereToFindEnum
    {
        public static readonly string Distilleries  = "Винокурни";
        public static readonly string Caves         = "Пещеры";
        public static readonly string Cities        = "Города";
        public static readonly string Imps          = "Бесы";
        public static readonly string ImpTerritory  = "Территория бесов";
        public static readonly string Mages         = "Маги";
        public static readonly string PowerPlace    = "Места силы";
        public static readonly string Fields        = "Поля";
        public static readonly string Plantations   = "Плантации";
        public static readonly string Forests       = "Леса";
        public static readonly string Mountains     = "Горы";
        public static readonly string Underground   = "Под землей";
        public static readonly string BlueMountains = "Синие горы";
        public static readonly string EndriagNests  = "Гнезда эндриаг";
        public static readonly string OceanFloor    = "Дно океана";
        public static readonly string Rivers        = "Реки";
        public static readonly string RiversCoast   = "Берега реки";
        public static readonly string Coastline     = "Побережье";
        public static readonly string Swamps        = "Болота";
        public static readonly string Buy           = "Покупается";
        public static readonly string Craft         = "Изготавливается";
        public static readonly string Anywhere      = "Где угодно на поверхности земли";
        public static readonly string Everywhere    = "Где угодно";
        public static readonly string Campfire      = "Костер";
        public static readonly string Burned        = "Сгоревшие предметы";
        public static readonly string Monsters      = "Чудовища";
        public static readonly string Animals       = "Животные";
        public static readonly string Birds         = "Птицы";
        public static readonly string Wolfs         = "Волки";    // Должны быть ссылки на существ, а не как описание
        public static readonly string Wyverns       = "Виверны";  // Должны быть ссылки на существ, а не как описание
    }
}
