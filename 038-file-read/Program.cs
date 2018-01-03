using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _038_file_read
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("../../file1.txt"));
            string[] file2Lines = File.ReadAllLines("../../file2.txt");

            Console.WriteLine();

            foreach (string line in file2Lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
