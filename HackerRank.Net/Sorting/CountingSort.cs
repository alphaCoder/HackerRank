using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Sorting
{
    public class CountingSort
    {
        public static string[] Sort(int[] ints, string[] values)
        {
            int n = 101;
            int[] aux = new int[n];
            string[] sortedValues = new string[values.Length];
            //frequency counts
            for(int i=0; i<ints.Length; i++)
            {
                aux[ints[i] + 1]++; 
            }

            //frequency counts cummulates
            for(int i=1; i<n; i++)
            {
                aux[i] += aux[i - 1];
            }

            //place string in right order
            for(int i=0; i<ints.Length; i++)
            {
                var val = values[i];
                if (i < ints.Length / 2)
                {
                    val = "-";
                }
                sortedValues[aux[ints[i]]++] = val;
            }

            return sortedValues;
        }

    }
}
