using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes
{
    class Soldier : Hero
    {


        public Soldier(string name, Hero.Sex sex, Hero.Type type)
            : base(name, sex, type)
        {
            Console.WriteLine("Soldier {0} is ready for a fight", name);
        }

        public override void Action()
        {

        }
    }
}
