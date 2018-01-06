using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_generic_constraints
{
    // "Edible" as in you can put it in your mouth...not as in you should!
    interface Edible
    {
        string name { get; set; }
        void eat();
    }
}
