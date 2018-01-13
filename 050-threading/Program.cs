using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _050_threading
{
    class Program
    {
        static void printMegaDouble(int n)
        {
            long n2 = n;
            for (int i = 0; i < n; i++)
                n2 *= 2;
            Console.WriteLine("The MegaDouble of " + n + " is " + n2 + ".");
        }

        static void Main(string[] args)
        {
            // Declare threads with their functions
            Thread th1 = new Thread(() => printMegaDouble(32));
            Thread th2 = new Thread(() => printMegaDouble(24));
            Thread th3 = new Thread(() => Console.WriteLine("hello"));

            // Begin each thread
            th1.Start();
            th2.Start();
            th3.Start();

            // Wait for each thread to complete before continuing
            th1.Join();
            th2.Join();
            th3.Join();

            Console.ReadKey();
        }
    }
}
