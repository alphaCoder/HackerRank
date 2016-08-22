using System;
using HackerRank.Net.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class CamelCaseCountTests
    {
        [TestMethod]
        public void When_saveChangesInTheEditor_Should_Return_5()
        {
            var cc = new CamelCaseWordCount();
            string s = "saveChangesInTheEditor";
            var expected = 5;
            var actual = cc.Count(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
