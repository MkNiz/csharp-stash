using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068_optional_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Item itm1 = new Item("Pretzel Stick", "A pretzel, as a stick", 7);
            Item itm2 = new Item("Foo", "Not a bar");

            Console.WriteLine(itm1);
            Console.WriteLine(itm2);

            Console.ReadKey();
        }
    }
}
