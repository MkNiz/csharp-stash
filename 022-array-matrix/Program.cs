using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_array_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays within an array
            int[][] grid = new int[3][];
            grid[0] = new int[3];
            grid[1] = new int[3];
            grid[2] = new int[3];

            grid[1][1] = 50;

            Console.WriteLine("grid[1][1]: " + grid[1][1]);

            // Multi-dimensional array
            int[,] anotherGrid = new int[3, 3];
            anotherGrid[0, 2] = 400;

            Console.WriteLine("anotherGrid[0, 2]: " + anotherGrid[0, 2]);

            Console.ReadKey();
        }
    }
}
