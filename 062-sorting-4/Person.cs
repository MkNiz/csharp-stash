namespace _062_sorting_4
{
    class Person
    {
        private string firstName;
        public string FirstName { get { return firstName; } private set { firstName = value; } }

        private string lastName;
        public string LastName { get { return lastName; } private set { lastName = value; } }

        private string middleName;
        public string MiddleName { get { return middleName; } private set { middleName = value; } }

        public string Name
        {
            get
            {
                if (middleName == null)
                    return firstName + " " + lastName;
                else
                    return firstName + " " + middleName + " " + lastName;
            }
        }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public Person(string first, string middle, string last) : this(first, last)
        {
            MiddleName = middle;
        }
    }
}
