using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (count <= 20)
            {
                Console.WriteLine("count: " + count);
                count++;
            }

            Console.WriteLine("Loop completed, back in main block");

            Console.ReadKey();
        }
    }
}
