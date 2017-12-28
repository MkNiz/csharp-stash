using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_interface
{
    interface Person
    {
        string Job { get; }
        string Name { get; set; }

        void Greet();
    }
}
