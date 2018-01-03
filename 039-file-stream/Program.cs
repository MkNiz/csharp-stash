using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _039_file_stream
{
    class Program
    {
        static void Main(string[] args)
        {
            // Streaming output
            FileStream myStream = File.OpenWrite("output.txt");
            StreamWriter sw = new StreamWriter(myStream);

            sw.Write("Henlo");
            sw.Write("fff\n");
            sw.Write("cheas");

            sw.Flush();
            sw.Close();

            Console.WriteLine("Wrote output.txt.");

            // Streaming input
            Console.WriteLine("Reading input.txt:\n");

            myStream = File.OpenRead("../../input.txt");
            StreamReader sr = new StreamReader(myStream);

            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());

            sr.Close();

            Console.ReadKey();
        }
    }
}
