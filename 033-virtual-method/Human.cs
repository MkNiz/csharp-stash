using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_virtual_method
{
    class Human
    {
        protected string name { get; set; }

        public Human(string name)
        {
            this.name = name;
        }

        public virtual void introduction()
        {
            Console.WriteLine("I am " + name + ".");
        }
    }
}
