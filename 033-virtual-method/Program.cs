using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_virtual_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Human jessie = new Human("Jessie");
            jessie.introduction();

            Doctor jessa = new Doctor("Jessa", "Science Facts");
            jessa.introduction();

            Console.ReadKey();
        }
    }
}
