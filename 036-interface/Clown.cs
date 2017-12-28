using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_interface
{
    class Clown : Person
    {
        public string Name { get; set; }

        public string Job
        {
            get
            {
                return "Clown";
            }
        }

        public Clown(string Name)
        {
            this.Name = Name;
        }

        public void Greet()
        {
            Console.WriteLine("Honk honk!!! I'm " + Name + "!");
        }
    }
}
