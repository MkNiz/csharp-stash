using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using properties to create an object with specific instance variable values
            Ship goodShip = new Ship() { speed = 24, TurboCannons = 4 };

            goodShip.BoardPassengers(512);
            goodShip.Describe();

            Console.ReadKey();
        }
    }
}
