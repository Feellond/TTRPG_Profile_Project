﻿namespace TTRPG_Project.BL.DTO.Items
{
    public class BlueprintComponentListDTO
    {
        public int Id { get; set; }
        public int? BlueprintId { get; set; }
        public int? ComponentId { get; set; }
        public int Amount { get; set; }
    }
}
