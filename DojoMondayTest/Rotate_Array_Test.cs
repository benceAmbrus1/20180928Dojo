﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20180928DojoMonday;

namespace DojoMondayTest
{
    [TestClass]
    public class Rotate_Array_Test
    {
        [TestMethod]
        public void RotateArrayTest_Valid() //rename method
        {
            // Arrange

            int[] testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int testCounter = 4;
            int[] expected = new int[] {7, 8, 9, 10, 1, 2, 3, 4, 5, 6 };

            // Act

            int[] actual = Rotate_Array.Rotate(testArray, testCounter);

            // Assert

            Assert.AreEqual(expected, actual, "The 2 array are not the same");

        }
    }
}
