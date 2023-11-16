namespace TTRPG_Project.DAL.Const
{
    public enum ItemType
    {
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

    public enum ItemAvailabilityType
    {
        Everywhere = 1,
        Common = 2,
        Poor = 3,
        Rare = 4,
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
        CantHide = 1,
        Large = 2,
        Small = 3,
        Tiny = 4,
    }

    public enum ArmourType
    {
        Light = 1,
        Medium = 2,
        Heavy = 3,
    }

    public enum SubstanceType
    {
		Aer = 1, // Аер
        Hydragenium = 2, // Гидроген
        Quebrith = 3, // Квебрит
        Vermilion = 4, // Киноварь
        Vitriol = 5, // Купорос
        Rebis = 6, // Ребис
        Sol = 7, // Солнце
        Fulgur = 8, // Фульгор
        Aether = 9, // Эфир
    }
}
