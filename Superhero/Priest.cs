using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    public class Priest : Hero
    {
        private byte energyAmount;
        public Priest(string name, Hero.Sex sex, Hero.Type type, byte energyAmount)
            : base(name, sex, type)
        {
            this.energyAmount = Clamp(energyAmount, 1, 50);
            Greeting();
        }

        public byte EnergyAmount => energyAmount;
        public override void Greeting()
        {
            Console.WriteLine("I'm {0}. My powers serve the light and are wrecking for the darkness.", name);
        }
        public Priest GiveEnergyPotion(Hero hero)
        {
            if (hero.HeroType == Type.Kind) hero.Energy += energyAmount;
            else hero.Energy -= energyAmount;
            return this;
        }

    }
}
