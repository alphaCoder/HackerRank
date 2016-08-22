using System;
using HackerRank.Net.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class MarsExplorationTests
    {
        [TestMethod]
        public void When_SOSSPSSQSSOR_Should_Return_3()
        {
            var input = "SOSSPSSQSSOR";
            int expected = 3;
            int actual = MarsExploration.Missing(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void When_SOSSOT_Should_Return_1()
        {
            var input = "SOSSOT";
            int expected = 1;
            int actual = MarsExploration.Missing(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
