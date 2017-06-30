using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Searching
{
    public class HackerLandTransmitters
    {

        public static int CountTransmitters(int[] arr, int range)
        {
            int installations = 0;
            Array.Sort(arr);
            Dictionary<int, int> visitedMap = new Dictionary<int, int>();
            Dictionary<int, bool> arrMap = new Dictionary<int, bool>();
            for(int i =0; i< arr.Length; i++)
            {
                arrMap[arr[i]] = true;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (visitedMap.ContainsKey(arr[i])) continue;
                
                if (i >= 1)
                {
                    int prevRange = visitedMap[arr[i - 1]];

                    if ( (prevRange + range) >=arr[i] && visitedMap.ContainsKey(prevRange))
                    {
                        visitedMap.Add(arr[i], prevRange);
                        continue;
                    }
                }
                int ai = arr[i];
                int val = (ai + range);
                while (val != ai-1)
                {
                    if (arrMap.ContainsKey(val))  //we make sure to install on the house
                    {
                        visitedMap[ai] = val;
                        visitedMap[val] = val;
                        break;
                    }
                    val--;
                }

                installations++;
            }

            return installations;
        }

        public static int CountTransmitters1(int[] arr, int range)
        {
            int tranmitters = 0;
            Array.Sort(arr);
            for(int i=0; i<arr.Length; i++)
            {
                int start = arr[i];
                int last = arr[i] + range;
                if(last >= arr.Length) //this would be the last possible transmitter spot which covers rest the houses
                {
                    tranmitters++;
                    break;
                }
                else
                {
                    for(int j = last; j>= start; j--)
                    {
                        if(arr.Contains(j))
                        {
                            i = i + j + range; //move the i pointer;
                            tranmitters++;
                            break;
                        }
                    }
                }
            }

            return tranmitters;
        }
    }
}
