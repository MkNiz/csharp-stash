using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_derived_classes_in_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor[] allActors =
            {
                new Actor("The Stand-In", 10, 1, 1),
                new Hero("Valiant Bob", "Knight", 22, 13, 20),
                new Hero("Ms. De Mynre", "Villain", 16, 16, 16),
                new Monster("Goblin Bob", "Goblin", 8, 12, 10)
            };

            foreach (Actor actor in allActors)
            {
                actor.smileForCamera();
            }
            Console.WriteLine("\nCheese!");

            Console.ReadKey();
        }
    }
}
