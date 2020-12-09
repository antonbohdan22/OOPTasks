using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon;
using Heroes;

namespace Runner
{
    class Runner
    {
        static void Main(string[] args)
        {
            Wiseman wiseman = new Wiseman("Tesla", Hero.Sex.Male, Hero.Type.Kind);
            Console.WriteLine(wiseman.Phrases[0]);
            Console.ReadKey();
        }
    }
}
