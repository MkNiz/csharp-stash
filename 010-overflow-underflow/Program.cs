using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_overflow_underflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            Console.WriteLine("a = " + a);
            a += 1;
            Console.WriteLine("a += 1 = " + a);

            byte b = 0;
            Console.WriteLine("b = " + b);
            b -= 1;
            Console.WriteLine("b -= 1 = " + b);

            Console.ReadKey();
        }
    }
}
