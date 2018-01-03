using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _040_file_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writing a binary file
            FileStream myStream = File.OpenWrite("DATA.DAT");
            BinaryWriter bw = new BinaryWriter(myStream);

            bw.Write("chease\n");
            bw.Write("meets\n");
            bw.Write("paystrees");

            bw.Flush();
            bw.Close();

            Console.WriteLine("DATA.DAT saved.");
            Console.WriteLine();

            // Reading a binary file
            Console.WriteLine("Reading back individual strings from DATA.DAT:");

            myStream = File.OpenRead("DATA.DAT");
            BinaryReader br = new BinaryReader(myStream);
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadString());

            Console.ReadKey();
        }
    }
}
