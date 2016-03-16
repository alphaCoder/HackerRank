using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Net.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Net.Tests.DynamicProgramming
{
    [TestClass]
    public class MaxSubArrayTests
    {
        [TestMethod]
        public void CalulateMaxSubArray_All_PositiveNos_Test()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4 };
            int expected = 10;

            // Act
            int actual = SubArray.CalulateMaxSubArray(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalulateMaxSubArray_All_NegativeNos_Test()
        {
            // Arrange
            int[] arr = { -1, -2, -3, -4 };
            int expected = -1;

            // Act
            int actual = SubArray.CalulateMaxSubArray(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalulateMaxSubArray_All_MixNos_Test()
        {
            // Arrange
            int[] arr = { 1, -2, 3, 4 };
            int expected = 7;

            // Act
            int actual = SubArray.CalulateMaxSubArray(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalulateMaxSubArray_All_Zeros_Test()
        {
            // Arrange
            int[] arr = { 0,0,0 };
            int expected = 0;

            // Act
            int actual = SubArray.CalulateMaxSubArray(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
