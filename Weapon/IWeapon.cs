﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    public interface IWeapon
    {
        string Name { get;}

        void Attack();
    }
}
