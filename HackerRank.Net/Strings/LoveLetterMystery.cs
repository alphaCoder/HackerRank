using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class LoveLetterMystery
    {
        public static int Solve(string s)
        {
            int i = 0, j = s.Length - 1;
            int change = 0;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    int ch = (int)s[j];
                    int left = (int)s[i];
                    if (s[i] > s[j])
                    {
                        ch = (int)s[i];
                        left = (int)s[j];
                    }
                    while (ch != left)
                    {
                        ch--;
                        change++;
                    }
                }
                i++; j--;
            }
            return change;
        }
    }
}
