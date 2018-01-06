using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_creating_generics
{
    class Person
    {
        private string firstName { get; set; }
        private string middleName { get; set; }
        private string lastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {
            this.middleName = middleName;
        }

        public override string ToString()
        {
            if (middleName != null)
            {
                return firstName + " " + middleName + " " + lastName;
            }
            else
            {
                return firstName + " " + lastName;
            }
        }
    }
}
