using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Net.Sorting;
using System.Linq;
namespace HackerRank.Net.Tests.Sorting
{
    [TestClass]
    public class QuicksortInsertionsortRuntimeSwapsTests
    {
        [TestMethod]
        public void QuickSortTests_Should_Return_8()
        {
            int[] input = new int[] { 1, 3, 9, 8, 2, 7, 5 };
            int expected = 8;
            int actual = QuicksortInsertionsortRuntimeSwaps.QuickSort(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertionSortTests_Should_Return_9()
        {
            int[] input = new int[] { 1, 3, 9, 8, 2, 7, 5 };
            int expected = 9;
            int actual = QuicksortInsertionsortRuntimeSwaps.InsertionSort(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1_Should_Return_16()
        {
            int[] arr1 = "10 9 8 7 6 5 4 3 2 1".Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] arr2 = "10 9 8 7 6 5 4 3 2 1".Split(' ').Select(x => int.Parse(x)).ToArray();
            int expected = 16;
            int q = QuicksortInsertionsortRuntimeSwaps.QuickSort(arr1);
            int i = QuicksortInsertionsortRuntimeSwaps.InsertionSort(arr2);

            Assert.AreEqual(expected, (i - q));
        }
    }
}
