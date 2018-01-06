using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_creating_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Cyberlink<string> link1 = new Cyberlink<string>(0, "Welcome", "http://www.google.com");
            link1.describe();

            Cyberlink<int> link2 = new Cyberlink<int>(1, "Number of dogs", 15);
            link2.describe();

            Cyberlink<Person> link3 = new Cyberlink<Person>(2, "Author", new Person("John", "Henry", "Bortson"));
            link3.describe();

            Console.ReadKey();
        }
    }
}
