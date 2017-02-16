using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    public class BearAndSteadyGene
    {
        
        public static int Stabilize(string s)
        {
            Dictionary<char, int> genes = new Dictionary<char, int>() { { 'A', 0 }, { 'C', 0 }, { 'G', 0 }, { 'T', 0 } };
            var maxIdx = s.Length - 1;
            int N = s.Length / 4;
            int len = s.Length;
            int i = len-1;
            for(; i>=0; i--)
            {
                genes[s[i]]++;
                if(!Satisfied(genes, N))
                {
                    genes[s[i]]--;
                    maxIdx = i + 1;
                    break;
                }
            }
            if (Satisfied(genes, N) && maxIdx == len-1 && i == -1)
            {
                return 0;
            }
            var min =int.MaxValue;
            for(int minIndex = -1; minIndex < len-1 && maxIdx < len  && minIndex < maxIdx; minIndex++)
            {
                while(!Satisfied(genes, N) && maxIdx < len)
                {
                    genes[s[maxIdx]]--;
                    maxIdx++;
                }

                if (!Satisfied(genes, N) || maxIdx == len) break;
                var ml  = Math.Max(maxIdx - minIndex - 1, 0);
                min = Math.Min(ml, min);
                genes[s[minIndex+1]]++;
            }
          
            return min;
        }

        static bool Satisfied(Dictionary<char, int> genes, int N = 0)
        {
            return (genes['A'] <= N && genes['C'] <= N && genes['G'] <= N && genes['T'] <= N);
        }
    }
}
