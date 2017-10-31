using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assigning indices after creating
            int[] nums = new int[5];

            nums[0] = 5;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 555;
            nums[4] = 424;

            // Assigning indices during creation
            int[] moreNums = new int[3] { 10, 20, 30};

            Console.WriteLine("nums[3]: " + nums[3]);
            Console.WriteLine("moreNums[0]: " + moreNums[0]);

            Console.ReadKey();
        }
    }
}
