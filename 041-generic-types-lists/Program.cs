using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_generic_types_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();

            stringList.Add("weff");
            stringList.Add("bork");
            stringList.Add("whine");

            intList.Add(5);
            intList.Add(4);
            intList.Add(3);
            intList.Add(2);
            intList.Add(1);

            foreach (string s in stringList)
            {
                Console.WriteLine("Dog says: " + s);
            }

            foreach (int i in intList)
            {
                Console.WriteLine(i + "!!!");
            }

            Console.ReadKey();

        }
    }
}
