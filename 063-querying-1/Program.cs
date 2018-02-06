using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_querying_1
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

            foreach (OrganDonor donor in donors)
            {
                if (donor.Kidneys > 0)
                    Console.WriteLine(donor.Name + " could donate a kidney.");
            }

            Console.ReadKey();
        }
    }
}
