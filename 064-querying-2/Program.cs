using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _064_querying_2
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

            Predicate<OrganDonor> testKidneys = delegate (OrganDonor od) { return od.Kidneys > 0; };
            List<OrganDonor> donorsWithKidneys = donors.FindAll(testKidneys);

            Console.WriteLine("Donors with kidneys available:");
            Action<OrganDonor> output = Console.WriteLine;
            donorsWithKidneys.ForEach(output);

            Console.ReadKey();
        }
    }
}
