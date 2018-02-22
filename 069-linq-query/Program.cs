using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_linq_query
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>
            {
                new Item("Foo", 5),
                new Item("Bar", 13),
                new Item("Foobar", 0),
                new Item("Skates", 0),
                new Item("Parmesan", 12),
                new Item("Plant", 0)
            };

            var zeroItems = from Item i in items
                            where i.Quantity == 0
                            select i;

            foreach (Item itm in zeroItems)
                Console.WriteLine(itm);

            Console.ReadKey();
        }
    }
}
