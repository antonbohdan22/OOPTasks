using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Superhero

{
    public abstract class Firegun : IWeapon
    {
        protected string name;
        protected int magazineCapacity;
        protected int currentMagazineBulletsQuantity;
        protected int reloadingTime;
        protected bool burstShooting;

        public string Name => name;

        public int MagazineCapacity => magazineCapacity;

        public int CurrentMagazineBulletsQuantity => currentMagazineBulletsQuantity;

        public int ReloadingTime => reloadingTime;

        public bool BurstShooting => burstShooting;

        public abstract void Attack();

        public void Reload()
        {
            Console.WriteLine("\nI'm reloading. Cover me.");
            for (int i = reloadingTime; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("{0} is reloaded and ready to fire up. Let's smash 'em.", name);
        }
    }

}

