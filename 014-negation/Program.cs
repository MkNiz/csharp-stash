using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_negation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool catIsAsleep = false;

            if (catIsAsleep)
            {
                Console.WriteLine("The cat is asleep.");
            }

            if (!catIsAsleep)
            {
                Console.WriteLine("The cat is not asleep.");
            }

            Console.ReadKey();
        }
    }
}
