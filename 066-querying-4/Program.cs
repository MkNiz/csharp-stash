using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _066_querying_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OrganDonor> donors = new List<OrganDonor>
            {
                new OrganDonor("Steve", 2),
                new OrganDonor("Julie", 0),
                new OrganDonor("Postulio", 1),
                new OrganDonor("Matilda", 2),
                new OrganDonor("Oedbaed", 0)
            };

            Console.WriteLine("Donors with available kidneys:");
            foreach (OrganDonor donor in donors.Where(od => od.Kidneys > 0))
                Console.WriteLine("\t- " + donor.Name);

            Console.ReadKey();
        }
    }
}
