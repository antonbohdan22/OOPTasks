using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Superhero
{
    public class Pistol : Firegun
    {
        public Pistol(string name, int magazineCapacity, int currentMagazineBulletsQuantity, int reloadingTime)
        {
            this.name = name;
            this.magazineCapacity = magazineCapacity;
            this.currentMagazineBulletsQuantity = currentMagazineBulletsQuantity;
            this.reloadingTime = reloadingTime;
            burstShooting = false;
        }

        public override void Attack()
        {
            Console.WriteLine("PUFF");
            currentMagazineBulletsQuantity--;
        }
    }
}
