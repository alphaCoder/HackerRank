using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Net.Sorting;
using Newtonsoft.Json;

namespace HackerRank.Net.Tests.Sorting
{
    [TestClass]
    public class CountingSortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ints = new int[] { 0, 6, 0, 6, 4, 0, 6, 0, 6, 0, 4, 3, 0, 1, 5, 1, 2, 4, 2, 4 };
            string[] strs = new string[] {"ab", "cd", "ef", "gh", "ij", "ab", "cd", "ef", "gh", "ij", "that", "be", "to", "be", "question", "or", "not", "is", "to", "the"};
            var sortedStr = CountingSort.Sort(ints, strs);
            Console.WriteLine(string.Join(" ", sortedStr));
            string expected = "- - - - - to be or not to be - that is the question - - - -";
            string actual = string.Join(" ", sortedStr);
            Assert.AreEqual(expected, actual);

        }
    }
}
