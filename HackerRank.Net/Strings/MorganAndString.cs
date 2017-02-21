using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class MorganAndString
    {
        public static string ArrangeLexicographically(string s1, string s2)
        {
            s1 = s1 + "z";
            s2 = s2 + "z";

            StringBuilder sb = new StringBuilder(s1.Length + s2.Length);
            int i = 0, j = 0;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            while (i < s1.Length - 1 && j < s2.Length - 1)
            {

                if (Compare1(s1, s2, i, j) < 0)
                {
                    sb.Append(s1[i++]);
                    while (s1[i - 1] == s1[i] && i < s1.Length - 1)
                    {
                        sb.Append(s1[i++]);
                    }
                }
                else
                {
                    sb.Append(s2[j++]);
                    while (s2[j - 1] == s2[j] && j < s2.Length - 1)
                    {
                        sb.Append(s2[j++]);
                    }
                }

            }
            stopwatch.Stop();
            sb.Append(s1.Substring(i, s1.Length - i - 1));
            sb.Append(s2.Substring(j, s2.Length - j - 1));

            Console.WriteLine("elapsed time strings in  ms: {0}", stopwatch.ElapsedMilliseconds);
            return sb.ToString();
        }

        private static int Compare(string a, string b, int i, int j)
        {
            int len1 = a.Length - i, len2 = b.Length - j;
            int result = String.Compare(a.Substring(i, len1), b.Substring(j, len2), true);
            return result;
        }

        static int Compare1(String a, String b, int i, int j)
        {
            int len1 = a.Length - i, len2 = b.Length - j, k = 0;
            int lim = Math.Min(len1, len2);
            while (k < lim)
            {
                char c1 = a[i + k], c2 = b[j + k];
                if (c1 != c2) return c1 - c2;
                k++;
            }
            return len2 - len1;
        }
    }
}
