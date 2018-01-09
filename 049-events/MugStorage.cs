using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_events
{
    class MugStorage
    {
        private List<Mug> Mugs;
        public event EventHandler<MugEventArgs> MugAdded;
        public event EventHandler<MugEventArgs> MugRemoved;

        public MugStorage(params Mug[] mugs)
        {
            Mugs = new List<Mug>();
            add(mugs);
        }

        public MugStorage()
        {
            Mugs = new List<Mug>();
        }

        public void add(Mug m)
        {
            Mugs.Add(m);
            OnMugAdded(m);
        }

        public void add(params Mug[] mugs)
        {
            foreach (Mug m in mugs)
            {
                Mugs.Add(m);
                OnMugAdded(m);
            }
        }

        public void remove(int idx)
        {
            OnMugRemoved(Mugs.ElementAt(idx));
            Mugs.RemoveAt(idx);
        }

        public void remove(Mug m)
        {
            Mugs.Remove(m);
            OnMugRemoved(m);
        }

        public void printContents()
        {
            Console.WriteLine("Contents of mug storage:");
            foreach (Mug m in Mugs)
            {
                Console.WriteLine("\t" + m.description());
            }
            Console.WriteLine();
        }

        // Event Methods
        public void OnMugAdded(Mug m)
        {
            MugAdded?.Invoke(this, new MugEventArgs(m));
        }

        public void OnMugRemoved(Mug m)
        {
            MugRemoved?.Invoke(this, new MugEventArgs(m));
        }
    }
}
