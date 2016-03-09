using System;
using HackerRank.Net.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.Strings
{
    [TestClass]
    public class ReverseShuffleMergeTests
    {
        [TestMethod]
        public void GetSubstringTests_1()
        {
            //Arrange
            var expected = "aaaaabccigicgjihidfiejfijgidgbhhehgfhjgiibggjddjjd";
            var input = "djjcddjggbiigjhfghehhbgdigjicafgjcehhfgifadihiajgciagicdahcbajjbhifjiaajigdgdfhdiijjgaiejgegbbiigida";

            //Act
            var actual = ReverseShuffleMerge.GetSubstring(input);

            Console.WriteLine(actual);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSubstringTests_2()
        {
            //Arrange
            var expected = "egg";
            var input = "eggegg";

            //Act
            var actual = ReverseShuffleMerge.GetSubstring(input);

            Console.WriteLine(actual);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSubstringTests_3()
        {
            //Arrange
            var expected = "ba";
            var input = "aabb";

            //Act
            var actual = ReverseShuffleMerge.GetSubstring(input);

            Console.WriteLine(actual);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSubstringTests_4()
        {
            //Arrange
            var expected = "aaaaaabaaceededecbdb";
            var input = "bdabaceadaedaaaeaecdeadababdbeaeeacacaba";

            //Act
            var actual = ReverseShuffleMerge.GetSubstring(input);

            Console.WriteLine(actual);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetSubstringTests_5()
        {
            //Arrange
            var expected = "abe";
            var input = "abeeba";

            //Act
            var actual = ReverseShuffleMerge.GetSubstring(input);

            Console.WriteLine(actual);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
