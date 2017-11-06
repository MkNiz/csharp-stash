using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero grandalf = new Hero("Grandalf the Grody", "Whizzard", 50, 22, 13);
            Monster badclown = new Monster("Bad Clown", "Terrible Clown", 10, 18, 27);
            grandalf.attack(badclown);
            badclown.battleCry();
            badclown.attack(grandalf);
            grandalf.battleCry();

            Console.ReadKey();
        }
    }
}
