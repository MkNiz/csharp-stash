using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_delegate
{
    class StringsManipulator
    {
        private List<string> StringsA;
        private List<string> StringsB;

        public StringsManipulator()
        {
            StringsA = new List<string>();
            StringsB = new List<string>();
        }

        public void addToA(string s)
        {
            StringsA.Add(s);
        }

        public void addAllToA(params string[] strs)
        {
            foreach (string s in strs)
                addToA(s);
        }

        public void addAllToB(params string[] strs)
        {
            foreach (string s in strs)
                addToB(s);
        }

        public void addToB(string s)
        {
            StringsB.Add(s);
        }

        // Will run the delegate for every combination of strings from StringsA and StringsB
        public List<string> forEachToList(StringDelegate sDel)
        {
            List<string> results = new List<string>();

            foreach (string sa in StringsA)
                foreach (string sb in StringsB)
                {
                    results.Add(sDel(sa, sb));
                    results.Add(sDel(sb, sa));
                }

            return results;
        }
    }
}
