using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, can you give me a number?");
            string result = Console.ReadLine();

            try
            {
                int n = Convert.ToInt32(result);
                Console.WriteLine("Ah, the number " + n + ". Nice choice.");
            }
            catch (Exception e)
            {
                Console.WriteLine("That...wasn't a number, but OK.");
                Console.WriteLine("Specifically, my issue is: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
