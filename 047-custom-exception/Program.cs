using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_custom_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name:");
            string uin = Console.ReadLine();
            try
            {
                if (uin.ToLower() != "bob")
                {
                    throw new NotBobException(uin);
                }
                else
                {
                    Console.WriteLine("Welcome, Bob.");
                }
            }
            catch (NotBobException nbe)
            {
                Console.WriteLine(nbe.Message);
            }

            Console.ReadKey();
        }
    }
}
