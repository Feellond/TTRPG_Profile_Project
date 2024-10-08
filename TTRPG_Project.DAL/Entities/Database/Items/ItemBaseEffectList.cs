﻿using System.ComponentModel.DataAnnotations.Schema;
using TTRPG_Project.DAL.Entities.Database.Additional;

namespace TTRPG_Project.DAL.Entities.Database.Items
{
    public class ItemBaseEffectList
    {
        public int? Id { get; set; }
        public int? ItemBaseId { get; set; }
        public ItemBase? ItemBase { get; set; }
        public int? EffectId { get; set; }
        public Effect? Effect { get; set; }
        public string Damage { get; set; } = string.Empty;
        public int ChancePercent { get; set; }
        public bool IsDealDamage { get; set; } = false;
    }
}
