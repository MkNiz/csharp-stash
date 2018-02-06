using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_data_absence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human> {
                new Human("Don Arbuckle"),
                new Human("Natalie Ice") { Dogs = 5 },
                new Human("Dr. Feelsgood") { Dogs = 1 },
                new Human("Jasper Horace"),
                new Human("Mary Yram") { Dogs = 999 }
            };

            // This query doesn't catch humans with 0 dogs, but with "null" dogs, meaning
            // that the "dogs" variable was never initialized
            Console.WriteLine("Humans that have not yet owned dogs:");
            foreach (Human being in humans.Where(h => h.Dogs == null))
                Console.WriteLine("\t- " + being.Name);

            Console.ReadKey();
        }
    }
}
