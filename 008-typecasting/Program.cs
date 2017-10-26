using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_typecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting
            byte a = 16;
            int b = 512;
            long c = a * b;
            Console.WriteLine("a * b = c = " + c);

            float d = 1.25f;
            float e = b + d;
            Console.WriteLine("b + d = e = " + e);

            // Explicit Casting
            int f = (int)a;
            Console.WriteLine("f is the byte a cast as an integer");

            Console.ReadKey();
        }
    }
}
