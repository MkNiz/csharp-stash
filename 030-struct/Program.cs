using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_struct
{
    struct MyTime
    {
        private int seconds;

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                Console.WriteLine("Now contains " + value + " seconds.");
                seconds = value;
            }
        }

        public int Minutes
        {
            get
            {
                return seconds / 60;
            }
            set
            {
                Console.WriteLine("Now contains " + value + " minutes.");
                seconds = value * 60;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyTime t = new MyTime();

            t.Seconds = 500;
            t.Minutes = 5;
            Console.WriteLine("That's " + t.Seconds + " seconds.");

            Console.ReadKey();
        }
    }
}
