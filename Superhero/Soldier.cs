using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    public class Soldier : Hero
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

        public override void Greeting()
        {
            Console.WriteLine("Soldier {0} is ready for a fight", name);
        }

        public Soldier NextWeapon()
        {
            int index = weapons.IndexOf(currentWeapon) + 1;
            if (index >= weapons.Count) index = 0;
            currentWeapon = weapons[index];
            Console.WriteLine("\n{0} switched weapon to {1}", name, currentWeapon.Name);
            return this;
        }

        public Soldier BurstShooting(int shootsQuantity)
        {
            if (!currentWeapon.BurstShooting)
            {
                Console.WriteLine("This weapon doesn't support burst shooting. Press 'S' for switching to next weapon or press any key to continue.");
                if(ConsoleKey.S == Console.ReadKey().Key)
                {
                    NextWeapon();
                    BurstShooting(shootsQuantity);
                }
            }
            else
            {
                while (shootsQuantity-- > 0) Shoot();
            }
            return this;
        }

        public Soldier Shoot()
        {
            if (energy >= 4)
            {
                if (currentWeapon.CurrentMagazineBulletsQuantity == 0)
                {
                    Console.WriteLine("{0} is out of bullets. Press 'R' to reload or 'S' for switching to another weapon.", currentWeapon.Name);
                    do
                    {
                        ConsoleKey pressedKey = Console.ReadKey().Key;
                        if (pressedKey == ConsoleKey.R)
                        {
                            currentWeapon.Reload();
                            break;
                        }
                        else if (pressedKey == ConsoleKey.S)
                        {
                            NextWeapon();
                            break;
                        }
                    } while (true);
                }
                Console.WriteLine("{0} shoots: ", name);
                currentWeapon.Attack();
                energy -= 4;
            }
            else
            {
                Console.WriteLine("Not enough energy, you need to rest a bit or request a heal.");
            }
            return this;
        }
    }
}
