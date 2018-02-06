using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _065_querying_3
{
    class OrganDonor
    {
        private string name;
        public string Name { get { return name; } }

        private uint kidneys;
        public uint Kidneys { get { return kidneys; } }

        public OrganDonor(string donorName, uint numKidneys)
        {
            name = donorName;
            kidneys = numKidneys;
            if (kidneys > 2)
                kidneys = 2;
        }

        public void loseKidney()
        {
            if (kidneys > 0)
                kidneys--;
        }

        public override string ToString()
        {
            return name + ": " + kidneys + " kidneys";
        }
    }
}
