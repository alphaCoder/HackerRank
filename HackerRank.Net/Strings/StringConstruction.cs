using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class StringConstruction
    {
        public static int CalculateCost(string s)
        {
            HashSet<char> hs = new HashSet<char>(s.ToArray());
            return hs.Count;
        }
    }
}
