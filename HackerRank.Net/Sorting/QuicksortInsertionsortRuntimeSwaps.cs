using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Sorting
{
    public class QuicksortInsertionsortRuntimeSwaps
    {
        private static int quickSortSwaps = 0;
        
        public static int QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
            return quickSortSwaps;
        }

        static void QuickSort(int[] arr, int lo, int hi)
        {
            if (lo >= hi) return;
            int p = Partition(arr, lo, hi);
            QuickSort(arr, lo, p - 1);
            QuickSort(arr, p + 1, hi);
        }

        static int Partition(int[] arr, int lo, int hi)
        {
            int i = lo; 
            int pivot = arr[hi];
            for(var j = lo; j<hi; j++)
            {
                if(arr[j] <= pivot)
                {
                    Exch(arr, i, j);
                    i++;
                    quickSortSwaps++;
                }
            }
            Exch(arr, i, hi);
            quickSortSwaps++;
            return i;
        }

        public static int InsertionSort(int[] arr)
        {
            int insertionSortSwaps = 0;
            for (int i=1; i<arr.Length; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if(arr[j] < arr[j-1])
                    {
                        Exch(arr, j, j-1);
                        insertionSortSwaps++;
                    }
                }
            }
            return insertionSortSwaps;
        }

        static void Exch(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
