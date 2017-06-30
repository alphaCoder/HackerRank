using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Searching
{
    /*
    Based on this idea: https://www.quora.com/What-is-the-logic-used-in-the-HackerRank-Maximise-Sum-problem
    First of all as we have given an array 3 3 9 9 5, find the prefix_sum[i]%m.
which will be 3 6 1 3 1.

The key-logic is, if the larger index(say j) has smaller prefix_sum than any smaller index (say i), then that sub-array (from i to j) can be a contender for our solution provided it's sum%m is maximum.

Consider following example : array is 3 2 7 4 and m = 7
prefix_sum[i]%m = 3 5 5 2
indices :                 1 2 3 4

Now prefix_sum % m for i = 1 and j = 4, prefix_sum[i] > prefix_sum[j], which means that sub-array from i to j (excluding i) is a contender. In simple words, prefix_sum[1]%m = 3 and prefix_sum[4]%m = 2, it means 6 or some multiple of 6 would have been added to get prefix_sum[j]%m, which is desired result.

What we can do, is sort the array by their prefix_sum and corresponding indices.
2 3 5 5
4 1 2 3
Now, we have to find the minimum difference b/w all the prefix_sum % m, such that the first one's index is larger than the latter one's index, which is 1. Now subtract it from m and find the answer, which is 6 in this case. 
    */
    public class MaximumSubArraySumWithMod
    {
        public class Node
        {
            public Node(ulong sum, int index)
            {
                Sum = sum;
                Index = index;
            }
            public ulong Sum { get; set; }
            public int Index { get; set; }
        }
        public static ulong ComputeMaxSubArraySum(ulong[] input, ulong mod)
        {
            ulong[] prefixSum = new ulong[input.Length];
            ulong max = 0;
            Tuple<ulong, int,bool>[] pairs = new Tuple<ulong, int, bool>[input.Length];
            max = prefixSum[0] = input[0] % mod;
            pairs[0] = Tuple.Create(prefixSum[0], 0, false);
            for(int i=1; i<input.Length; i++)
            {
                prefixSum[i] = (input[i] %mod + prefixSum[i-1]%mod) % mod;
                max = Math.Max(max, prefixSum[i]);
                pairs[i] = Tuple.Create(prefixSum[i], i, false);
            }

            Array.Sort(prefixSum);
            var pair1 = pairs.First(x => x.Item1 == prefixSum[0] && x.Item3 == false);
            ulong result = ulong.MaxValue;
            int minInd = 0;
            HashSet<int> lookup = new HashSet<int>();
            
            for(int i=1; i<input.Length; i++)
            {
                lookup.Add(pair1.Item2);
                var pair2 = pairs.First(x => x.Item1 == prefixSum[i] && !lookup.Contains(x.Item2));
                if(pair1.Item2 > pair2.Item2)
                {
                    var minDiff = pair2.Item1 - pair1.Item1;
                    if(minDiff < result)
                    {
                        result = minDiff;
                        minInd = i;
                    }
                }
                pair1 = pair2;
            }
            result = Math.Max(max, mod - result);
            
            return result; 
        }

        public static ulong ComputeMaxSubArraySum1(ulong[] input, ulong mod)
        {
            ulong max = input[0] % mod;
            Node[] pairs = new Node[input.Length];
            pairs[0] = new Node(max, 0);
            ulong iSum = 0;
            for (int i = 1; i < input.Length; i++)
            {
                iSum = (input[i] % mod + pairs[i - 1].Sum % mod) % mod;
                max = Math.Max(max, iSum);
                pairs[i] = new Node(iSum, i);
            }

            pairs = pairs.OrderBy(x => x.Sum).ToArray();
          //  Array.Sort(pairs);
            
            ulong result = ulong.MaxValue;
            
            for (int i = 0; i < input.Length-1; i++)
            {
            
                if (pairs[i].Index > pairs[i+1].Index)
                {
                    var minDiff = pairs[i+1].Sum- pairs[i].Sum;
                    if (minDiff < result)
                    {
                        result = minDiff;
                    }
                }
            }
            result = Math.Max(max, mod - result);

            return result;
        }
    }
}
