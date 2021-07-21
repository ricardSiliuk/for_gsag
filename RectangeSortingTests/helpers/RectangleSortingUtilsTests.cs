using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangeSorting.helpers;
using RectangeSorting.objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RectangeSorting.helpers.Tests
{
    [TestClass()]
    public class RectangleSortingUtilsTests
    {
        [TestMethod()]
        public void AssertCorrectGetPercentOfSquaresCalculation()
        {
            List<Rectangle> rectangles = new List<Rectangle>
            {
                new Rectangle(1, 1),
                new Rectangle(1, 2),
                new Rectangle(2, 3)
            };
            Assert.AreEqual((double)1 / 3 * 100, RectangleSortingUtils.GetPercentOfSquares(rectangles));
        }

        [TestMethod()]
        public void AssertProperlyReadsFileGivenThatFileIsCorrect()
        {
            List<Rectangle> rectangles = RectangleSortingUtils.GetRectanglesFromFile("assets/test_input.txt");
            Assert.AreEqual(10, rectangles.Count);
        }
    }
}