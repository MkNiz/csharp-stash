using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Clown binky = new Clown("Binky");
            Bogeyman spoops = new Bogeyman("Spoops");

            binky.Greet();
            Console.WriteLine(binky.Name + " is a " + binky.Job);
            spoops.Greet();
            Console.WriteLine(spoops.Name + " is a " + spoops.Job);

            Console.ReadKey();
        }
    }
}
