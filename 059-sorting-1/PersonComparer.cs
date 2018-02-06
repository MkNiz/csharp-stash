using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_sorting_1
{
    class PersonComparer : IComparer<Person>
    {
        public int Compare(Person a, Person b)
        {
            // People are compared by the alphabetic order of their last names
            return a.LastName.CompareTo(b.LastName);
        }
    }
}
