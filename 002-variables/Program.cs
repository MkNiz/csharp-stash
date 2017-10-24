using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // short - small integer between -32,768 and 32,767
            short var1 = -9999;
            Console.WriteLine("var1: " + var1);

            // int - medium integer between -2,147,483,648 and 2,147,483,647
            int var2 = 999999999;
            Console.WriteLine("var2: " + var2);

            // long - large integer between -9,224,372,036,854,775,808 and 9,223,372,036,852,775,807
            long var3 = -9999999999999999;
            Console.WriteLine("var3: " + var3);

            Console.ReadKey();
        }
    }
}
