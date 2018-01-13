using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "good day sir";
            Console.WriteLine("Original String: " + myString);
            Console.WriteLine("Screamed String: " + myString.Scream());

            Console.ReadKey();
        }
    }
}
