using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_events
{
    class Program
    {
        public static void whenMugAdded(object sender, MugEventArgs ea)
        {
            Console.WriteLine("A mug was added to mug storage:\n\t" + ea.MugData.description() + "\n");
        }

        public static void whenMugRemoved(object sender, MugEventArgs ea)
        {
            Console.WriteLine("A mug was removed from mug storage:\n\t" + ea.MugData.description() + "\n");
        }

        static void Main(string[] args)
        {
            Mug m1 = new Mug("Dad Mug", "#1 Dad");
            Mug m2 = new Mug("Cool Mug", "Cool", Color.BLUE, Color.PURPLE);
            MugStorage cabinet = new MugStorage(m1, m2);
            cabinet.printContents();

            cabinet.MugAdded += whenMugAdded;
            cabinet.MugRemoved += whenMugRemoved;

            cabinet.add(new Mug("Bad Mug", "This is a bad mug", Color.PINK, Color.PINK));
            cabinet.remove(m2);
            cabinet.printContents();

            Console.ReadKey();
        }

    }
}
