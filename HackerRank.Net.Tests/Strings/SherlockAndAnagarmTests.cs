using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Net.Strings;
namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class SherlockAndAnagarmTests
    {
        [TestMethod]
        public void When_abba_Should_4()
        {
            var input = "abba";
            var expected = 4;
            var actual = SherlockAndAnagrams.CountAnagramPairs(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_ifailuhkqq_Should_3()
        {
            var input = "ifailuhkqq";
            var expected = 3;
            var actual = SherlockAndAnagrams.CountAnagramPairs(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_hucpoltgty_Should_2()
        {
            var input = "hucpoltgty";
            var expected = 2;
            var actual = SherlockAndAnagrams.CountAnagramPairs(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_ovarjsnrbf_Should_2()
        {
            var input = "ovarjsnrbf";
            var expected = 2;
            var actual = SherlockAndAnagrams.CountAnagramPairs(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_pvmupwjjjf_Should_6()
        {
            var input = "pvmupwjjjf";
            var expected = 6;
            var actual = SherlockAndAnagrams.CountAnagramPairs(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_iwwhrlkpek_Should_3()
        {
            var input = "iwwhrlkpek";
            var expected = 3;
            var actual = SherlockAndAnagrams.CountAnagramPairs(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
