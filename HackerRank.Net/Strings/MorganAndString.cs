using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class MorganAndString
    {
       public static string ArrangeLexicographically(string s1, string s2)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0, j = 0;
            while (i < s1.Length - 1 && j < s2.Length - 1)
            {
                if (Compare(s1, s2, i, j) < 0)
                {
                    sb.Append(s1[i++].ToString());
                }
                else {
                    sb.Append(s2[j++].ToString());
                }
            }
            sb.Append(s1.Substring(i, s1.Length - i - 1));
            sb.Append(s2.Substring(j, s2.Length - j - 1));

            return sb.ToString();
        }
       private static int Compare(String a, String b, int i, int j)
        {
            int len1 = a.Length - i, len2 = b.Length - j;
            return a.Substring(i, len1).CompareTo(b.Substring(j, len2));
        }
    }
}
