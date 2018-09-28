using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20180928DojoMonday;
using System.Linq;

namespace DojoMondayTest
{
    /// <summary>
    /// Summary description for TwoSumTest
    /// </summary>
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TwoSumTest_Valid()
        {
            // Arrange
            int[] testArray = new int[] { 15, 7, 11, 2 };
            int testTarget = 9;
            int[] expected = new int[] { 1, 3 };

            // Act
            int[] actual = TwoSum.TwoSumMethod(testArray, testTarget);

            // Assert
            Assert.AreEqual(true, actual.SequenceEqual(expected), "The 2 array are not the same");
        }

        [TestMethod]
        public void TwoSumTest_Valid2()
        {
            // Arrange
            int[] testArray = new int[] { 15, 0, 14, 5, 6, 70 };
            int testTarget = 20;
            int[] expected = new int[] { 0, 3 };

            // Act
            int[] actual = TwoSum.TwoSumMethod(testArray, testTarget);

            // Assert
            Assert.AreEqual(true, actual.SequenceEqual(expected), "The 2 array are not the same");
        }
    }
}
