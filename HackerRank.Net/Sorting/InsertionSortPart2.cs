using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Sorting
{
    public class InsertionSortPart2
    {
        public static string Sort(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i<arr.Length; i++)
            {
                for(int j=i; j>0; j--)
                {
                    if(arr[j] < arr[j-1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
                sb.Append(string.Join(" ", arr));
                if(i != arr.Length-1)
                {
                    sb.AppendLine();
                }
            }
            
            return sb.ToString();
        }
    }
}
