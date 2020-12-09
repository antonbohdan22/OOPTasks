using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    class Runner
    {
        static void Main(string[] args)
        {
            Wiseman wiseman = new Wiseman("Confucius", Hero.Sex.Male, Hero.Type.Kind, new List<string>()
            {
                "Never do to others what you would not like them to do to you.",
                "Wheresoever you go, go with all your heart.",
                "Our greatest glory is not in never falling, but in rising every time we fall."
            });


            wiseman.SayWiseQuote();

            wiseman.SayWiseQuote(0)
                .SayWiseQuote(1)
                .SayWiseQuote();

            wiseman.AddQuote("Choose a job you love, and you will never have to work a day in your life.");
            wiseman.SayWiseQuote(5)
                .SayWiseQuote(3);

            Soldier soldier1 = new Soldier("Jack", Hero.Sex.Male, Hero.Type.Evil, new List<Firegun>() {
                new Pistol("Glock-17", 20, 20, 3),
                new Rifle("AK-47", 30, 30, 5, true)});

            Soldier soldier2 = new Soldier("Rick", Hero.Sex.Male, Hero.Type.Kind, new List<Firegun>() {
                            new Pistol("USP", 12, 12, 3),
                            new Rifle("M4A1", 30, 30, 5, true)});

            soldier1.Shoot()
                .Shoot()
                .Shoot()
                .Shoot()
                .BurstShooting(7);

            soldier2.NextWeapon();
            soldier2.BurstShooting(5)
                .Shoot()
                .Shoot();



            Priest priest = new Priest("Jinny", Hero.Sex.Female, Hero.Type.Kind, 30);
            priest.GiveBigEnergyPotion(soldier2);
            soldier2.BurstShooting(30);
            Console.ReadKey();
        }
    }
}
