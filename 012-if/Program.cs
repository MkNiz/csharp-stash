using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int apples = 5;
            bool isHungry = true;

            if (apples > 3)
            {
                Console.WriteLine("You have over 3 apples.");
            }

            if (apples == 10)
            {
                Console.WriteLine("This isn't run");
            }
            else
            {
                Console.WriteLine("You do not have 10 apples.");
            }

            if (apples == 1 && isHungry)
            {
                Console.WriteLine("You are so hungry that you eat the last apple!");
                apples--;
            }
            else if (apples > 0 && isHungry)
            {
                Console.WriteLine("You are hungry, so you eat an apple.");
                apples--;
            }
            else
            {
                Console.WriteLine("You don't feel hungry...yet.");
            }

            Console.ReadKey();
        }
    }
}
