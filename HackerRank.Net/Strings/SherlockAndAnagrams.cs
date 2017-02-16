using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class SherlockAndAnagrams
    {
        public static int CountAnagramPairs(string s)
        {
            int count = 0;
            for (int len = 1; len < s.Length; len++)
            {
                for (int i = 0; i < s.Length - len; i++)
                {
                    var sub1 = s.Substring(i, len);
                    for (int j = i + 1; j < s.Length - len + 1; j++)
                    {
                        var sub2 = s.Substring(j, len);
                        if (IsAnagram(sub1, sub2))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        private static bool IsAnagram(string a, string b)
        {
            if (a.Length != b.Length) return false;
            int[] ch = new int[26];

            for (int i = 0; i < a.Length; i++)
            {
                ch[a[i] - 97]++;
                ch[b[i]-97]--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (ch[i] != 0) return false;
            }
            return true;
        }
    }
}
