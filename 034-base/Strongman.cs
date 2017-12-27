using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_base
{
    class Strongman : Human
    {
        public Strongman(string name, int power) : base(name, power) { }

        public override void introduction()
        {
            Console.WriteLine("I am " + name + ", the circus strongman!");
        }

        public override void flex()
        {
            base.flex();
            Console.WriteLine("The audience gasps! Incredible!");
        }

    }
}
