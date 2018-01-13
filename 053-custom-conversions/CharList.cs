using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_custom_conversions
{
    class CharList
    {
        private List<char> Data;

        // Implicit conversion (of string to CharList)
        static public implicit operator CharList(string s)
        {
            return new CharList(s);
        }

        // Explicit conversion (of CharList to string)
        static public explicit operator string(CharList cl)
        {
            return cl.ToString();
        }

        public char this[int idx]
        {
            get
            {
                return Data[idx];
            }

            set
            {
                Data[idx] = value;
            }
        }

        public CharList()
        {
            Data = new List<char>();
        }

        public CharList(string fromString) : this()
        {
            Set(fromString);
        }

        public void Set(string s)
        {
            Data.Clear();
            foreach (char c in s)
                Data.Add(c);
        }

        public int Count()
        {
            return Data.Count;
        }

        public override string ToString()
        {
            string s = "";
            foreach (char c in Data)
                s += c;
            return s;
        }

        public void Cheer()
        {
            foreach (char c in Data)
                Console.Write(c + "!! ");
            Console.WriteLine();
        }
    }
}
