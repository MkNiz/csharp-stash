using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_generic_types_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> powerLevels = new Dictionary<string, int>();
            powerLevels["Gofu"] = 9001;
            powerLevels["Pant"] = 120;
            powerLevels["Steve"] = 0;

            foreach (KeyValuePair<string, int> item in powerLevels) {
                Console.WriteLine(item.Key + "'s power level is " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
