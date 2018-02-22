using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068_optional_parameters
{
    class Item
    {
        private string name;
        private string description;
        private int? quantity;

        public Item(string name, string description, int? quantity = 1)
        {
            this.name = name;
            this.description = description;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return "[" + quantity + "] " + name + "(s): \n\t" + description;
        }
    }
}
