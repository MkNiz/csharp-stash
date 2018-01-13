using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_custom_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion from string to CharList
            string str = "burp";
            CharList cl1 = str;
            cl1.Cheer();

            // Explicit Conversion from CharList to string
            CharList cl2 = new CharList("Cyber Crime");
            str = (string)cl2;
            Console.WriteLine(str + "!!!");

            Console.ReadKey();
        }
    }
}
