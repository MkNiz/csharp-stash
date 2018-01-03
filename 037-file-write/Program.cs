using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _037_file_write
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("hello.txt", "Hello World!");
            Console.WriteLine("Wrote hello.txt");

            string[] lines = new string[3];
            lines[0] = "hello";
            lines[1] = "HeLlo";
            lines[2] = "HELLO!";
            File.WriteAllLines("hello2.txt", lines);
            Console.WriteLine("Wrote hello2.txt");

            Console.ReadKey();
        }
    }
}
