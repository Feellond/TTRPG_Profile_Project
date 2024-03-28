using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class ClassResponce
    {
        public int Count { get; set; }
        public List<Class>? Classes { get; set; }
    }
}
