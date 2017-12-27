using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_base
{
    class Human
    {
        protected string name { get; set; }
        protected int power { get; set; }

        public Human(string name, int power)
        {
            this.name = name;
            this.power = power;
        }

        public virtual void introduction()
        {
            Console.WriteLine("I am " + name + ".");
        }

        public virtual void flex()
        {
            Console.WriteLine(name + " flexes, revealing " + power + " power.");
        }
    }
}
