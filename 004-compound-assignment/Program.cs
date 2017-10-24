using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_compound_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("x = " + x);

            x += 2;
            Console.WriteLine("x += 2: x = " + x);

            x -= 4;
            Console.WriteLine("x -= 4: x = " + x);

            x *= 2;
            Console.WriteLine("x *= 2: x = " + x);

            x /= 4;
            Console.WriteLine("x /= 4: x = " + x);

            x %= 2;
            Console.WriteLine("x %= 2: x = " + x);

            Console.ReadKey();
        }
    }
}
