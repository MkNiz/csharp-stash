using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_data_absence
{
    class Human
    {
        private string name;
        public string Name { get { return name; } }

        private uint? dogs;
        public uint? Dogs
        {
            get { return dogs; }
            set { dogs = value; }
        }

        public Human(string humanName)
        {
            name = humanName;
        }
    }
}
