﻿using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("Armors")]
    public class Armor : ItemBase
    {
        public int Type { get; set; }
        public int EquipmentType { get; set; }
        public int Reliability { get; set; }
        public int AmountOfEnhancements { get; set; }
        public int Stiffness { get; set; }
        public int ItemOriginType { get; set; }
    }
}
