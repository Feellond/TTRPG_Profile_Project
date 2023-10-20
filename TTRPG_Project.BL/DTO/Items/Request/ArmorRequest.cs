﻿using TTRPG_Project.BL.DTO.Base;

namespace TTRPG_Project.BL.DTO.Items.Request
{
    public class ArmorRequest : BaseItemDTO
    {
        public int Reliability { get; set; }
        public int AmountOfEnhancements { get; set; }
        public int Stiffness { get; set; }
    }
}
