using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_extension_method
{
    static class StringScream
    {
        private static Random rand = new Random();

        public static string Scream(this string s)
        {
            return s.ToUpper() + "!!!!!!!!!!";
        }
    }
}
