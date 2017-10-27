using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = false;

            do
            {
                Console.WriteLine("I was run once even though the condition is false!");
            } while (condition);

            Console.ReadKey();
        }
    }
}
