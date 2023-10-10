using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creature
{
    public class Class : EntityDescriptionBase
    {
        public int Energy { get; set; }
        public List<string> MagicAbilities { get; set; }

    }
}
