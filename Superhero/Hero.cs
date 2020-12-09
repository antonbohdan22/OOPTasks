using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    public abstract class Hero
    {
        protected string name;
        protected Sex sex;
        protected Type type;
        protected byte energy;

        protected Hero(string name, Sex sex, Type type)
        {
            this.name = name;
            this.sex = sex;
            this.type = type;
            energy = 100;
        }

        public abstract void Greeting();

        protected byte Clamp(byte value, byte min, byte max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        public byte Energy
        {
            get { return energy; }
            set { energy = Clamp(value, 0, 100); }
        }

        public string Name => name;

        public Sex HeroSex => sex;

        public Type HeroType => type;

        public enum Sex
        {
            Male,
            Female
        }

        public enum Type
        {
            Kind,
            Evil
        }
    }
}
