using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_sorting_1
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

            people.Sort(new PersonComparer());
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadKey();
        }
    }
}
