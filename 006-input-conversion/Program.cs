using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_input_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer:");
            string uInputIntString = Console.ReadLine();
            int uInputInt = Convert.ToInt32(uInputIntString);

            Console.WriteLine("Input a double:");
            string uInputDoubleString = Console.ReadLine();
            double uInputDouble = Convert.ToDouble(uInputDoubleString);

            Console.WriteLine(uInputInt + " * " + uInputDouble + " = " + (uInputInt * uInputDouble));

            Console.ReadKey();
        }
    }
}
