using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numDogs = 5;

            Console.WriteLine("Dogs: " + numDogs);

            switch (numDogs)
            {
                case 0:
                    Console.WriteLine("Can't believe you have no dogs...");
                    break;
                case 1:
                    Console.WriteLine("Only one dog? Pathetic.");
                    break;
                case 2:
                    Console.WriteLine("Two dogs? Nice.");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("That's a good amount of dogs.");
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("This number of dogs is a bit excessive.");
                    break;
                default:
                    Console.WriteLine("You have way too many dogs, I'm sorry.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
