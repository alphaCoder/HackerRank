using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Net.Sorting;
using System.Linq;
namespace HackerRank.Net.Tests.Sorting
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = new int[] { 5, 8, 1, 3, 7, 9, 2 };
            int[] arr1 = new int[] { 1, 3, 9, 8, 2, 7, 5 };
            int[] arr2 = new int[] { 1, 3, 9, 8 };
            int[] arr3 = new int[] { 9, 8, 6, 7, 3, 5, 4, 1, 2 };
            var arr4 = "406 157 415 318 472 46 252 187 364 481 450 90 390 35 452 74 196 312 142 160 143 220 483 392 443 488 79 234 68 150 356 496 69 88 177 12 288 120 222 270 441 422 103 321 65 316 448 331 117 183 184 128 323 141 467 31 172 48 95 359 239 209 398 99 440 171 86 233 293 162 121 61 317 52 54 273 30 226 421 64 204 444 418 275 263 108 10 149 497 20 97 136 139 200 266 238 493 22 17 39".Split(' ').Select(x => int.Parse(x)).ToArray();

          
            QuickSort.Sort(arr1);
        }
    }
}
