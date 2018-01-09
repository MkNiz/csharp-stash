using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_events
{
    class MugEventArgs : EventArgs
    {
        public Mug MugData { get; set; }
        
        public MugEventArgs(Mug m)
        {
            MugData = m;
        }
    }
}
