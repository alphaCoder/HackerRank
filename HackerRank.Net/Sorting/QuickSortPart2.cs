using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Sorting
{
    public class QuickSortPart2
    {
        public static List<int> Sort(int[] arr)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
                int pivot = 0;
            if (arr.Length < 2) return arr.ToList();
            else
            {
                pivot = arr[0];
                for(int i=0; i< arr.Length; i++)
                {
                    if(arr[i] < pivot)
                    {
                        left.Add(arr[i]);
                    }
                    else if(arr[i] > pivot)
                    {
                        right.Add(arr[i]);
                    }
                }
            }
            left = Sort(left.ToArray());
            right = Sort(right.ToArray());
            left.Add(pivot);
            left.AddRange(right);
            Console.WriteLine(string.Join(" ", left));
            return left;
        }
    }
}
