using System;
using HackerRank.Net.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class MorganAndStringTests
    {
        [TestMethod]
        public void ArrangeLexicographically_Test_1()
        {
            //Arrange
            string s1 = "JACK";
            string s2 = "DANIEL";

            string expected = "DAJACKNIEL";

            //Act
            var actual = MorganAndString.ArrangeLexicographically(s1, s2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
