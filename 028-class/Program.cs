using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("Bob", 22, 7);
            bob.Greet();

            bob.Grow();
            bob.Greet();

            bob.LoseCat();
            bob.Greet();

            bob.Grow(4);
            bob.AddCats(9000);
            bob.Greet();

            Console.ReadKey();
        }
    }
}
