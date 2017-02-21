using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Net.Sorting;
using System.Text;

namespace HackerRank.Net.Tests.Sorting
{
    [TestClass]
    public class InsertionSortPart2Tests
    {
        [TestMethod]
        public void Test1()
        {
            int[] input = { 1, 4, 3, 5, 6, 2 };
            StringBuilder sb = new StringBuilder();
            sb.Append("1 4 3 5 6 2").AppendLine().Append("1 3 4 5 6 2").AppendLine().Append("1 3 4 5 6 2").AppendLine().Append("1 3 4 5 6 2").AppendLine().Append("1 2 3 4 5 6");
            string expected = sb.ToString();
            string actual = InsertionSortPart2.Sort(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
