using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Priest : Hero
    {
        public Priest(string name, Hero.Sex sex, Hero.Type type)
            : base(name, sex, type)
        {
        }

        public void GivePotion(ref Hero hero)
        {
            if (hero.HeroType == Type.Kind) hero.Energy += 30;
            else hero.Energy -= 30;
        }

    }
}
