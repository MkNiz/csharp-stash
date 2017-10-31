using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Message("This is a message");
            Console.WriteLine("27 doubled is: " + DoubleInt(27));

            Console.ReadKey();
        }

        // Method that returns nothing and takes no arguments
        static void Hello()
        {
            Console.WriteLine("Hello!");
        }

        // Method that returns nothing and takes an argument
        static void Message(string msg)
        {
            Console.WriteLine("MESSAGE: " + msg);
        }

        // Method that returns a value and takes an argument
        static int DoubleInt(int doubled)
        {
            return doubled * 2;
        }
    }
}
