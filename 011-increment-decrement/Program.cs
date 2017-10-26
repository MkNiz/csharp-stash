using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_increment_decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 10;
            Console.WriteLine("1.) a = " + a);
            a++;
            Console.WriteLine("\t-> a++");
            Console.WriteLine("2.) a = " + a);
            a--;
            Console.WriteLine("\t-> a--");
            Console.WriteLine("3.) a = " + a);
            byte b = a++;
            Console.WriteLine("\t-> b = a++");
            Console.WriteLine("4.) a = " + a + "; b = " + b);
            b = ++a;
            Console.WriteLine("\t-> b = ++a");
            Console.WriteLine("5.) a = " + a + "; b = " + b);
            a = b--;
            Console.WriteLine("\t-> a = b--");
            Console.WriteLine("6.) a = " + a + "; b = " + b);
            a = --b;
            Console.WriteLine("\t-> a = --b");
            Console.WriteLine("7.) a = " + a + "; b = " + b);

            Console.ReadLine();
        }
    }
}
