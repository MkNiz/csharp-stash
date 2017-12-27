using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_abstract_class
{
    abstract class Actor
    {
        protected string name { get; set; }
        protected int atk { get; set; }
        protected int hp { get; set; }

        public abstract void taunt();

        public void attack(Actor target)
        {
            Console.WriteLine(name + " attacks!");
            target.defend(atk);
        }

        public void defend(int dmg)
        {
            Console.WriteLine(name + " takes " + dmg + " damage!");
            hp -= dmg;
            Console.WriteLine("They now have " + hp + " hp.");
            Console.WriteLine();
        }
    }
}
