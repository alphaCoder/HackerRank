using System;
using HackerRank.Net.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class BearAndSteadyGeneTests
    {
        [TestMethod]
        public void When_GAAATAAA_Should_Return_5()
        {
            var input = "GAAATAAA";
            var expected = 5;
            int actual = BearAndSteadyGene.Stabilize1(input);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void When_TGATGCCGTCCCCTCAACTTGAGTGCTCCTAATGCGTTGC_Should_Return_5()
        {
            var input = "TGATGCCGTCCCCTCAACTTGAGTGCTCCTAATGCGTTGC";
            var expected = 5;
            int actual = BearAndSteadyGene.Stabilize1(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
