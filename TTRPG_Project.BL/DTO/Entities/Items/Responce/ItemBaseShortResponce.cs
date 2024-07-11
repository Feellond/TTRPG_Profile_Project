using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.DTO.Entities.Items.Responce
{
    public class ItemBaseShortResponce
    {
        public int Count { get; set; }
        public List<ItemBase> Entitys { get; set; }
    }
}
