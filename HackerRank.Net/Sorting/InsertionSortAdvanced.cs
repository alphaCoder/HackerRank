using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Sorting
{
    public class InsertionSortAdvanced
    {
        public static long Sort(int[] arr)
        {
            var aux = new int[arr.Length];
            long shifts = Sort(arr, aux, 0, arr.Length - 1);
            return shifts;
        }
        static long Sort(int[] arr, int[] aux, int lo, int hi)
        {
            long shifts = 0;
            if (hi <= lo) return shifts;
            int mid = (lo + hi) / 2;
            shifts = Sort(arr, aux, lo, mid);
            shifts += Sort(arr, aux, mid + 1, hi);
            shifts += Merge(arr, aux, lo, mid + 1, hi);
            return shifts;
        }
        static long Merge(int[] arr, int[] aux, int lo, int mid, int hi)
        {
            long shifts = 0;
            for (int x = lo; x <= hi; x++)
            {
                aux[x] = arr[x];
            }
            int i = lo, j = mid;

            for (int k = lo; k <= hi; k++)
            {
                if (i >= mid) arr[k] = aux[j++];
                else if (j > hi) arr[k] = aux[i++];
                else if (aux[i] <= aux[j])
                {
                    arr[k] = aux[i++];
                }
                else
                {
                    shifts += (mid - i);
                    //if(k!= i) {shifts++;}
                    arr[k] = aux[j++];
                }
            }
            return shifts;
        }
    }
}
