using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Creatures
{
    public class Mutagen : EntityDescriptionBase
    {
        public int Complexity { get; set; }
        public string Effect { get; set; } = string.Empty;
        public string Mutation { get; set; } = string.Empty;
    }
}
