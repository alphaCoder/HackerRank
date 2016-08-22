using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class SuperSubString
    {
        public string SS(string s)
        {
            int i = 0;
            while(i<s.Length)
            {
                if(i == s.Length - 1 || s[i] != s[i+1])
                {
                    i++;
                }
                else
                {
                    if (i + 2 == s.Length) {
                        s = s.Substring(0, i);
                        break;
                    }
                    else {
                        s = s.Substring(0, i) + s.Substring(i + 2);
                        i = 0;
                     }
                    
                }
            }
            if (s.Length == 0) return "Empty String";
            return s;
        }
    }
}
