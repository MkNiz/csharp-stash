using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_inheritance
{
    class Hero : Actor
    {
        private string heroClass;

        public Hero(string name, string heroClass, int hp, int atk, int def) : base(name, hp, atk, def)
        {
            this.heroClass = heroClass;
        }

        public new void battleCry()
        {
            Console.WriteLine("I am " + name + " the " + heroClass + ", and you will fall before my mighty pinky!");
        }
    }
}
