using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_class
{
    class Person
    {
        private string name;
        private int age;
        private int cats;

        public Person(string name, int age, int cats)
        {
            this.name = name;
            this.age = age;
            this.cats = cats;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            cats = 0;
        }

        public Person(string name)
        {
            this.name = name;
            age = 0;
            cats = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void Grow(int years)
        {
            age += years;
        }

        public void Grow()
        {
            age += 1;
        }

        public void AddCat()
        {
            cats++;
        }

        public void AddCats(int cats)
        {
            this.cats += cats;
        }

        public void LoseCat()
        {
            cats--;
        }

        public void LoseCats(int cats)
        {
            this.cats -= cats;
        }

        public void Greet()
        {
            Console.WriteLine("Hi, I'm " + name + ". I am " + age + " years old and have " + cats + " cats.");
        }
    }
}
