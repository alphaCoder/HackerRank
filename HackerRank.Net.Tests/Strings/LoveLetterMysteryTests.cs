using System;
using HackerRank.Net.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class LoveLetterMysteryTests
    {
        [TestMethod]
        public void Solve_Test1()
        {
            //Arrange
            var input = "abc";
            var expected = 2;

            //Act
            var actual = LoveLetterMystery.Solve(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solve_Test2()
        {
            //Arrange
            var input = "abcba";
            var expected = 0;

            //Act
            var actual = LoveLetterMystery.Solve(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Solve_Test3()
        {
            //Arrange
            var input = "abcd";
            var expected = 4;

            //Act
            var actual = LoveLetterMystery.Solve(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Solve_Test4()
        {
            //Arrange
            var input = "cba";
            var expected = 2;

            //Act
            var actual = LoveLetterMystery.Solve(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
