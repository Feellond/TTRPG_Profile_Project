﻿using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Base;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("Blueprints")]
    public class Blueprint : ItemBase
    {
        public int Complexity { get; set; }
        public float TimeSpend { get; set; }
        public int AdditionalPayment { get; set; }
    }
}
