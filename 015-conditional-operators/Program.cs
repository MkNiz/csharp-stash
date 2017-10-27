using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_conditional_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("a && b: " + (a && b));
            Console.WriteLine("a || b: " + (a || b));
            Console.WriteLine("(a && b) || (a || b): " + ((a && b) || (a || b)));
            Console.WriteLine("(a && b) && (a || b): " + ((a && b) && (a || b)));

            Console.ReadKey();
        }
    }
}
