using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class PalindromeWithNDigitCheck
    {
        public static string CheckPalindrome(string s, int k)
        {
            int len = s.Length;
            StringBuilder sb = new StringBuilder(s);
            HashSet<int> updatedIndex = new HashSet<int>();
            int ik = k;
            for (int i = 0; i < len / 2; i++)
            {
                if (s[i] != s[len - i - 1])
                {
                    if (k <= 0) return "-1";
                    k--;
                    if (s[i] <= s[len - i - 1])
                    {
                        sb[i] = s[len - i - 1];
                        updatedIndex.Add(i);
                    }
                    else
                    {
                        updatedIndex.Add(len - i - 1);
                        sb[len - i - 1] = s[i];
                    }
                }
            }

            int j = 0;
            if (len % 2 == 1 && k == 1)
            {
                sb[len / 2] = '9';
                k--;
            }
            while (k > 0 && j <= len / 2)
            {
                if (ik != k && updatedIndex.Count == 0) break;
                if (sb[j] != '9' || sb[len - j - 1] != '9')
                {
                    if (sb[j] == '9' || sb[len - j - 1] == '9' || updatedIndex.Contains(j)|| updatedIndex.Contains(len - j - 1))
                    {
                        sb[j] = sb[len - j - 1] = '9';
                        k--;
                    }
                    else
                    {
                        if (k >= 2)
                        {
                            sb[j] = sb[len - j - 1] = '9';
                            k -= 2;
                        }
                    }

                }
                j++;
            }

            if (len % 2 == 1 && k == 1)
            {
                sb[len / 2] = '9';
                k--;
            }

            return sb.ToString();
        }
    }
}
