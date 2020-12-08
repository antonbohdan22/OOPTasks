using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon;

namespace Heroes
{
    class Soldier : Hero
    {
        protected List<Firegun> weapons;
        protected Firegun currentWeapon;

        public Soldier(string name, Hero.Sex sex, Hero.Type type, List<Firegun> weapons)
            : base(name, sex, type)
        {
            Console.WriteLine("Soldier {0} is ready for a fight", name);
            this.weapons = weapons;
            currentWeapon = weapons[0];
        }

        public List<Firegun> Weapons => weapons;

        public Firegun CurrentWeapon => currentWeapon;

        public Firegun NextWeapon()
        {
            int index = weapons.IndexOf(currentWeapon);
            if (index == weapons.Count - 1) index = 0;
            return weapons[index];
        }

        public void Shoot()
        {
            if (energy >= 5)
            {

                if (currentWeapon.CurrentMagazineBulletsQuantity == 0)
                {
                    Console.WriteLine("{0} is out of bullets. Press 'R' to reload or 'S' for switching to another weapon.");
                    do
                    {
                        int keyCode = Console.ReadKey().GetHashCode();
                        if (keyCode == 82)
                        {
                            currentWeapon.Reload();
                            break;
                        }
                        else if (keyCode == 83)
                        {
                            currentWeapon = NextWeapon();
                            break;
                        }
                    } while (true);
                }
                currentWeapon.Attack();
                energy -= 5;
            }
            else
            {
                Console.WriteLine("Not enough energy, you need to rest a bit or request a heal.");
            }
        }
    }
}
