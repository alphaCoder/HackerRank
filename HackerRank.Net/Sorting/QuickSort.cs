using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Sorting
{
    public class QuickSort
    {
        private static Random rng = new Random();
        public static void Sort(int[] arr)
        {
          //  Shuffle(arr);
            Sort(arr, 0, arr.Length-1);
            //Console.WriteLine(string.Join(" ", arr.Skip(lo).Take(hi - lo)));
         //   Console.WriteLine(string.Join(" ", arr));
        }

        private static void Sort(int[] arr, int lo, int hi)
        {
            if (lo >= hi) return;
            
            int p = Partition2(arr, lo, hi);
            Console.WriteLine(string.Join(" ", arr));
            Sort(arr, lo, p - 1);
            Sort(arr, p + 1, hi);
        }

        /// <summary>
        /// Fisher-Yates shuffle
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        private static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        /// <summary>
        /// 1. Repeat unit i & j pointer crosses
        /// 2. Scan i from left to right as long as arr[i] less than arr[lo]
        /// 3. Scan j from right to left as long as arr[j] greater than arr[lo]
        /// 4. Exchange arr[i] with arr[j]
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <returns></returns>
        private static int Partition(int[] arr, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            while (true)
            {
                while (arr[++i] < arr[lo])
                {
                    if (i == hi) break;
                }
                while (arr[lo] < arr[--j])
                {
                    if (j == lo) break;
                }
                if (i >= j) break; //when i crosses j
                Exch(arr, i, j);
            }
            Exch(arr, lo, j);
            return j;
        }

        private static int Partition1(int[] arr, int lo, int hi)
        {
            int i = lo-1, j = hi;
            int x = i;
            while (true)
            {
                
                while (arr[++i] < arr[hi])
                {
                    if (i == hi) break;
                }
                while (arr[hi] < arr[--j])
                {
                    if (j == lo) break;
                }
                if (j <= i) break; //when i crosses j
                var aj = arr[j];
                var ai = arr[i];
                Exch(arr, i, j);
            }
            Exch(arr, hi, i);
            return i;
        }

        private static int Partition2(int[] arr, int lo, int hi)
        {

            int pivot = arr[hi];
            int i = lo;
            for(int j = lo; j<hi; j++)
            {
                var aj = arr[j];
                var ai = arr[i];
                if(arr[j] <= pivot)
                {
                    Exch(arr, i, j);
                    i = i + 1;
                }
            }
            Exch(arr, i, hi);

            return i ;
        }

        private static void Exch(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
