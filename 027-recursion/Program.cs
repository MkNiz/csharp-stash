using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10! = " + Factorial(10));

            Console.ReadKey();
        }

        static int Factorial(int n)
        {
            switch (n)
            {
                case 0:
                case 1:
                    return 1;
                default:
                    return n * Factorial(n - 1);
            }
        }
    }
}
