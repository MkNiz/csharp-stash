using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_creating_generics
{
    class Cyberlink<T>
    {
        private int index { get; }
        private string text { get; set; }
        private T linksTo { get; set; }

        public Cyberlink(int index, string text, T linksTo)
        {
            this.index = index;
            this.text = text;
            this.linksTo = linksTo;
        }

        public Type linksToType()
        {
            return linksTo.GetType();
        }

        public void describe()
        {
            Console.WriteLine("[" + index + "]: '" + text + "' links to '" + linksTo + "', which is a(n) " + linksToType().Name + ".");
        }

    }
}
