using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_abstract_class
{
    class Hero : Actor
    {
        public Hero(string name)
        {
            this.name = name;
            atk = 8;
            hp = 20;
        }

        public override void taunt()
        {
            Console.WriteLine("I am " + name + ", and I will defeat you easily!");
            Console.WriteLine();
        }
    }
}
