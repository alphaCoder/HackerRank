using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class CamelCaseWordCount
    {
        public int Count(string s)
        {
            return s.Where(x => x >= 65 && x <= 90).Count() + 1;
        }
    }
}
