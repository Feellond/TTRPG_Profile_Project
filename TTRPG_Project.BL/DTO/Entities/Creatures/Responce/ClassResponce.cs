using TTRPG_Project.DAL.Entities.Database.Creatures;

namespace TTRPG_Project.BL.DTO.Entities.Creatures.Responce
{
    public class ClassResponce
    {
        public int Count { get; set; }
        public List<ClassResponceDTO>? Entitys { get; set; }
    }

    public class ClassResponceDTO : Class
    {
        public new SkillsTreeResponceDTO? SkillsTree { get; set; }
    }
}
