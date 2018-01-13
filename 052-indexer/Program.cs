using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Object3D point = new Object3D(6.6, 22.25, 9.99);
            Console.WriteLine("Object's X coordinate: " + point[0]);
            Console.WriteLine("Object's Y coordinate: " + point["y"]);
            Console.WriteLine("Object's Z coordinate: " + point["Z"]);

            Console.ReadKey();
        }
    }
}
