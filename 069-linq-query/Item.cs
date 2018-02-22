using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_linq_query
{
    class Item
    {
        public string Name;
        public int Quantity;

        public Item(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + "(" + Quantity + ")";
        }
    }
}
