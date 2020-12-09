using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    public class Wiseman : Hero
    {
        private List<string> quotes;
        public Wiseman(string name, Hero.Sex sex, Hero.Type type)
               : base(name, sex, type)
        {
            quotes = new List<string>();
            energy = 60;
            Greeting();
        }

        public Wiseman(string name, Hero.Sex sex, Hero.Type type, List<string> quotes)
               : base(name, sex, type)
        {
            this.quotes = quotes;
            energy = 60;
            Greeting();
        }

        public List<string> Quotes => quotes;

        public override void Greeting()
        {
            Console.WriteLine("{0}. My word is my weapon.", name);
        }

        public Wiseman SayWiseQuote()
        {
            Random random = new Random();
            Console.WriteLine(quotes[random.Next(0, quotes.Count)]);
            energy -= 2;
            return this;
        }

        public Wiseman SayWiseQuote(int index)
        {
            if ((index > quotes.Count - 1) || (index < 0)) Console.WriteLine("Didn't come up with anything smart. I should try to remember something I said in the past.");
            else Console.WriteLine(quotes[index]);
            energy -= 2;
            return this;
        }

        public Wiseman AddQuote(string quote)
        {
            quotes.Add(quote);
            return this;
        }
        
        public Wiseman AddQuote(params string[] quotes)
        {
            foreach(string quote in quotes)
            this.quotes.Add(quote);
            return this;
        }
    }
}
