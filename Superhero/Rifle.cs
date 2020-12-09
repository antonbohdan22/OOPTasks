using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Superhero
{
    class Rifle : Firegun
    {
        public Rifle(string name, int magazineCapacity, int currentMagazineBulletsQuantity, int reloadingTime, bool burstShooting)
        {
            this.name = name;
            this.magazineCapacity = magazineCapacity;
            this.currentMagazineBulletsQuantity = currentMagazineBulletsQuantity;
            this.reloadingTime = reloadingTime;
            this.burstShooting = burstShooting;
        }

        public override void Attack()
        {
            Console.WriteLine("PUFF");
            currentMagazineBulletsQuantity--;
        }       
    }
}
