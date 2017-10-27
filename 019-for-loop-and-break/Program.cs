using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_for_loop_and_break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterating:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i: " + i);
            }

            Console.WriteLine("Finding first number divisible by 5:");
            for (int j = 1; j < 999999999; j++)
            {
                if (j % 5 == 0)
                {
                    Console.WriteLine(j + " is divisible by 5.");
                    break;
                }
                else
                {
                    Console.WriteLine(j + " is not divisible by 5.");
                }
            }

            Console.ReadKey();
        }
    }
}
