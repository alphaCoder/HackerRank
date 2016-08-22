using System;
using HackerRank.Net.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class SuperSubStringTests
    {
        [TestMethod]
        public void When_aaabccddd_Should_Return_abd()
        {
            var ss = new SuperSubString();
            var input = "aaabccddd";
            var expected = "abd";
            var actual = ss.SS(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_bb_Should_Return_Empty_String()
        {
            var ss = new SuperSubString();
            var input = "bb";
            var expected = "Empty String";
            var actual = ss.SS(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_baab_Should_Return_Empty_String()
        {
            var ss = new SuperSubString();
            var input = "baab";
            var expected = "Empty String";
            var actual = ss.SS(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
