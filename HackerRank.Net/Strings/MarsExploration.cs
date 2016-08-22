using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class MarsExploration
    {
        public static int Missing(string s)
        {
            int count = 0;
            for(int i=2; i<s.Length; i +=3)
            {
                if (s[i] != 'S') count++;
                if (s[i - 1] != 'O') count++;
                if (s[i - 2] != 'S') count++;
            }
            return count;
        }
    }
}
