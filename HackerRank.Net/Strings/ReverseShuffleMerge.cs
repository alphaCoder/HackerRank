using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class ReverseShuffleMerge
    {
        public static string GetSubstring(string s)
        {
            int[] ch = new int[26];
            int[] left = new int[26];
            int[] added = new int[26];
            List<char> lex = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                int n = (int)s[i] - 97;
                ch[n]++;
            }
            int smallest = 25;
            for (int i = 0; i < 26; i++)
            {
                ch[i] = ch[i] / 2;
                if (ch[i] > 0 && i < smallest)
                {
                    smallest = i;
                }
            }

            for (int j = s.Length - 1; j >= 0; j--)
            {
                int n = (int)s[j] - 97;
                if (added[n] < ch[n] && (n == smallest || IsLessThanNextCritical(n, left,added,ch))
                   || left[n] == ch[n])
                {
                    lex.Add(s[j]);
                    added[n]++;
                    if (n == smallest && added[n] == ch[n])
                    {
                        smallest = ChooseNextSmallest(smallest, added, ch);
                    }
                }
                else {
                    left[n]++;
                }
            }
            return string.Join("", lex);
        }

        static bool IsLessThanNextCritical(int n, int[] left, int[] added, int[] ch)
        {
            for (int i = 0; i < 26; i++)
            {
                if (left[i] == ch[i] && added[i] < ch[i])
                {
                    if (n < i) return true;
                    return false;

                }
                   
                Console.WriteLine("i:{0},left[i]:{1}, added[i]:{2}, ch[i]:{3}, n:{4}", i,left[i], added[i], ch[i],n);
            }
            return false;
        }
        static int ChooseNextSmallest(int curr, int[] added, int[] ch)
        {
            int smallest = curr;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] != 0 && added[i] < ch[i])
                {
                    smallest = i;
                    break;
                }
            }
            return smallest;
        }
    }
}
