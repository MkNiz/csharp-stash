using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_generic_constraints
{
    class Food : Edible
    {
        public string name { get; set; }

        public Food(string name)
        {
            this.name = name;
        }

        public void eat()
        {
            Console.WriteLine("You eat the " + name + ". Yum!");
        }
    }
}
