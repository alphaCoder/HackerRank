using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.DynamicProgramming
{
    public class SubArray
    {
        public static int CalulateMaxSubArray(int[] arr)
        {
            int maxSofar = int.MinValue, maxEndingHere = 0;
            foreach (int t in arr)
            {
                maxEndingHere += t;
                maxSofar = Math.Max(maxSofar, maxEndingHere);
                if (maxEndingHere < 0)
                {
                    maxEndingHere = 0;
                }
            }
            return maxSofar;
        }

    }
}
