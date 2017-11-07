using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_virtual_method
{
    class Doctor : Human
    {
        private string field;

        public Doctor(string name, string field) : base(name)
        {
            this.field = field;
        }

        public override void introduction()
        {
            Console.WriteLine("Greetings, I am Dr. " + name + ", Doctor of " + field + ".");
        }
    }
}
