using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_interface
{
    class Bogeyman : Person
    {
        public string Name { get; set; }

        public string Job
        {
            get
            {
                return "Bogeyman";
            }
        }

        public Bogeyman(string Name)
        {
            this.Name = Name;
        }

        public void Greet()
        {
            Console.WriteLine("Raaaahhh! I am " + Name + "!");
        }
    }
}
