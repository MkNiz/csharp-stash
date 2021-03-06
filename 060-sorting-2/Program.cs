﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060_sorting_2
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

            people.Sort(delegate (Person a, Person b) {
                return a.LastName.CompareTo(b.LastName);
            });

            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadKey();
        }
    }
}
