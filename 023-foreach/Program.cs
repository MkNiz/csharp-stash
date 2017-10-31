using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classList = new string[] { "Joe", "Casey", "Millicent", "Jojo" };

            Console.WriteLine("Students in Class:");

            foreach (string student in classList)
            {
                Console.WriteLine("\t" + student);
            }

            Console.ReadKey();
        }
    }
}
