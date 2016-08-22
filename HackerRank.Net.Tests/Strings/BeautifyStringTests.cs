using System;
using HackerRank.Net.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class BeautifyStringTests
    {
        [TestMethod]
        public void When_0101010_Should_Return_2()
        {
            var bs = new BeautifyString();
            var input = "0101010";
            int expected = 2;
            int actual = bs.BS(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_01100_Should_Return_0()
        {
            var bs = new BeautifyString();
            var input = "01100";
            int expected = 0;
            int actual = bs.BS(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_0100101010_Should_Return_3()
        {
            var bs = new BeautifyString();
            var input = "0100101010";
            int expected = 3;
            int actual = bs.BS(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_95_Should_Return_6()
        {
            var bs = new BeautifyString();
            var input = "10110101101010001111011100100001010001111010110000111100110110111110011011000111100010011100111";
            int expected = 6;
            int actual = bs.BS(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
