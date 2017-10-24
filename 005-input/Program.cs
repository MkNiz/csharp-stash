using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text:");
            string userInput = Console.ReadLine();

            Console.WriteLine("You input: " + userInput);

            Console.ReadKey();
        }
    }
}
