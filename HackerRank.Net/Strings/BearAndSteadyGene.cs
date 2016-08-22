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
            int optimal = 0;

            //count the occurences
            for (int i = 0; i < s.Length; i++)
            {
                genes[s[i]]++;
            }

            int replaceCount = 0;
            //reduce char count/4

            genes['A'] = genes['A'] % 4;
            genes['C'] = genes['C'] % 4;
            genes['G'] = genes['G'] % 4;
            genes['T'] = genes['T'] % 4;

            replaceCount = genes['A'] + genes['C'] + genes['G'] + genes['T'];


            //now search the pattern
            for (int i = 0, j = 0; i < s.Length && replaceCount > 0; i++)
            {
                if (Satisfied(genes)) return optimal;


                optimal++;
                genes[s[i]]--;
                replaceCount--;



                if (j > 0) optimal++;
            }

            return optimal;
        }

        public static int Stabilize1(string s)
        {
            Dictionary<char, int> genes = new Dictionary<char, int>() { { 'A', 0 }, { 'C', 0 }, { 'G', 0 }, { 'T', 0 } };
            var maxIdx = s.Length - 1;
            int N = s.Length / 4;
            int len = s.Length;
            for(int i = len-1; i>=0; i--)
            {
                genes[s[i]]++;
                if(!Satisfied(genes, N))
                {
                    genes[s[maxIdx]]--;
                    maxIdx = i + 1;
                    break;
                }
            }
            
            var min = int.MaxValue;
            for(int minIndex = -1; minIndex < len-1 && minIndex < maxIdx && maxIdx < len; minIndex++)
            {
                while(!Satisfied(genes, N) && maxIdx < len)
                {
                    genes[s[maxIdx]]--;
                    maxIdx++;
                }

                if (!Satisfied(genes, N) || maxIdx == len) break;
                var total = maxIdx - minIndex -1;
                min = Math.Min(total, min);
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
