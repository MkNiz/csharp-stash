using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.PositiveInfinity;
            Console.WriteLine("Infinity: " + a);

            double b = double.NaN;
            Console.WriteLine("NaN(Not a Number): " + b);

            Console.WriteLine("Pi: " + Math.PI);

            Console.WriteLine("e: " + Math.E);

            // The following can be used for any numeric primitive type
            Console.WriteLine("Max value of 'byte': " + byte.MaxValue);
            Console.WriteLine("Min value of 'byte': " + byte.MinValue);

            Console.ReadKey();
        }
    }
}
