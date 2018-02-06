using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062_sorting_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person("John", "Toe"),
                new Person("Stacy", "Grace", "Umption"),
                new Person("Zoz", "Aardvark"),
                new Person("Samantha", "Laurence", "Roscoe")
            };

            foreach (Person person in people.OrderBy(p => p.LastName))
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadKey();
        }
    }
}
