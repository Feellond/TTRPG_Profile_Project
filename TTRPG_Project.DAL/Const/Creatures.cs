using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Project.DAL.Const
{
    public enum AbilityType
    {
        FullAction = 1,
        Action = 2,
        Passive = 3,
        Special = 4,
    }

    public enum AttackType
    {
        Piercing = 1,
        Slashing = 2,
		Bludgeoning = 3,
    }

    public enum StatusType
    {
        Resistance = 1,
        Immunity = 2,
        Vulnerability = 3,
    }

    public enum Complexity
    {
        EasySimple = 1,
        EasyComplex = 2,
        EasyDifficult = 3,
        MediumSimple = 4,
        MediumComplex = 5,
        MediumDifficult = 6,
        HardSimple = 7,
        HardComplex = 8,
        HardDifficult = 9,
        Exceptional = 10,
    }
}
