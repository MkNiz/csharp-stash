using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero jon = new Hero("Jon Arbinkle");
            Enemy gorfield = new Enemy("Gorfield", 17, 20);

            jon.taunt();
            gorfield.taunt();

            jon.attack(gorfield);
            gorfield.attack(jon);

            Console.ReadKey();
        }
    }
}
