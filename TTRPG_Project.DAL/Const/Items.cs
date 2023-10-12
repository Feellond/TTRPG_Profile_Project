namespace TTRPG_Project.DAL.Const
{
    public enum ItemType
    {
        BaseItem = 1,
        Tools = 2,
        AlchemicalItem = 3,
        Armor = 4,
        Weapon = 5,
        Formula = 6,
        Blueprint = 7,
        Component = 8,
    }

    public enum ItemAvailabilityType
    {
        Common = 1,
        Uncommon = 2,
        Rare = 3,
        Unique = 4,
    }

    //TODO: дополнить список
    public enum ItemStealthType
    {
        CantHide = 1,

    }

    public enum ArmourType
    {
        Light = 1,
        Medium = 2,
        Heavy = 3,
    }

    public enum SubstanceType
    {
        Aer = 1,
        Hydrogen = 2,
        Quebec = 3,
        Cinnabar = 4,
        Vitriol = 5,
        Rebis = 6,
        Sun = 7,
        Fulgor = 8,
        Ether = 9,
    }
}
