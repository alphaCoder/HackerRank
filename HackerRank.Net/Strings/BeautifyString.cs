using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class BeautifyString
    {
        string pattern = "010";

        public int BS(string s)
        {
            int count = 0;

            for (int i = 2; i < s.Length; i++)
            {
                if(s[i] =='0' && s[i-1] == '1' && s[i-2] == '0')
                {
                    count++; i += 2;
                }
            }
            return count;
        }
    }
}
