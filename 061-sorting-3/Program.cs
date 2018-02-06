using System;
using System.Collections.Generic;

namespace _061_sorting_3
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

            people.Sort((a, b) => a.LastName.CompareTo(b.LastName));

            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadKey();
        }
    }
}
