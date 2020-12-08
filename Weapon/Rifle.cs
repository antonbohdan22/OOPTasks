using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Weapon
{
    class Rifle : Firegun
    {
        public Rifle(string name, int magazineCapacity, int currentMagazineBulletsQuantity, int reloadingTime)
        {
            this.name = name;
            this.magazineCapacity = magazineCapacity;
            this.currentMagazineBulletsQuantity = currentMagazineBulletsQuantity;
            this.reloadingTime = reloadingTime;
        }

        public override void Attack()
        {
            Console.WriteLine("Puff");
        }       
    }
}
