using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_delegate
{
    class Program
    {
        public static string Hyphenate(string a, string b)
        {
            return a + "-" + b;
        }

        public static string LineBreak(string a, string b)
        {
            return a + "\n" + b;
        }

        public static string UpperSpace(string a, string b)
        {
            return a.ToUpper() + " " + b.ToUpper();
        }

        static void Main(string[] args)
        {
            StringDelegate upspacer = UpperSpace;

            string a = "Dog";
            string b = "Crimes";

            Console.WriteLine(upspacer(a, b));
            Console.WriteLine();

            StringsManipulator sm = new StringsManipulator();
            sm.addAllToA("aardvark", "noodle", "cutlery", "fish", "goat");
            sm.addAllToB("smile", "willfully", "goat", "chestnut", "boink");

            StringDelegate hyphenator = Hyphenate;
            List<string> compounds = sm.forEachToList(hyphenator);
            foreach (string s in compounds)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
