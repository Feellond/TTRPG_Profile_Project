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
        Stabbing = 1,
        Cutting = 2,
        Crushing = 3,
    }

    public enum StatusType
    {
        Resistance = 1,
        Immunity = 2,
        Vulnerability = 3,
    }

    public enum Complexity
    {
        EasyEasy = 1,
        EasyComplex = 2,
        EasyHard = 3,
        MediumEasy = 4,
        MediumComplex = 5,
        MediumHard = 6,
        HardEasy = 7,
        HardComplex = 8,
        HardHard = 9,
        Unique = 10,
    }
}
