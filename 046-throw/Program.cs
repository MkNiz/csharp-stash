using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("WARNING: Program working as intended");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
