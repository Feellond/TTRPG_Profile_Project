﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    [Table("ItemBaseEffectList")]
    public class ItemBaseEffectList
    {
        public int Id { get; set; }
        public int ItemBaseId { get; set; }
        public int EffectId { get; set; }
        public int Damage { get; set; }
        public int ChancePercent { get; set; }
        public bool IsDealDamage { get; set; } = false;
    }
}
