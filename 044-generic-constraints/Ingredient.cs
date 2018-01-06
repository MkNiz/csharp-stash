using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_generic_constraints
{
    class Ingredient : Edible
    {
        public string name { get; set; }

        public Ingredient(string name)
        {
            this.name = name;
        }

        public void eat()
        {
            Console.WriteLine("You hesitantly ingest the " + name + ". Blech!");
        }
    }
}
