using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("16, Doubled: " + Doubler(16));
            Console.WriteLine("5.252, Doubled: " + Doubler(5.252));
            Console.WriteLine("Gob, Doubled (with separator): " + Doubler("Gob", "! "));
            Console.WriteLine("Gob, Doubled (without separator): " + Doubler("Gob"));

            Console.ReadKey();
        }

        static int Doubler(int doubled)
        {
            return doubled * 2;
        }

        static double Doubler(double doubled)
        {
            return doubled * 2;
        }

        static string Doubler(string doubled, string separator)
        {
            return doubled + separator + doubled;
        }

        static string Doubler(string doubled)
        {
            return doubled + doubled;
        }
    }
}
