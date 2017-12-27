using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Human jon = new Human("Jon", 5);
            jon.introduction();
            jon.flex();

            Strongman greg = new Strongman("Greg", 9999);
            greg.introduction();
            greg.flex();

            Console.ReadKey();
        }
    }
}
