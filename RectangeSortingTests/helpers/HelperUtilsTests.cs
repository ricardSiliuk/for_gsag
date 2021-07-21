using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RectangeSorting.objects;

namespace RectangeSorting.helpers.Tests
{
    [TestClass()]
    public class HelperUtilsTests
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
            Assert.AreEqual((double)1 / 3 * 100, HelperUtils.GetPercentOfSquares(rectangles));
        }

        [TestMethod()]
        public void AssertProperlyReadsFileGivenThatFileIsCorrect()
        {
            List<Rectangle> rectangles = HelperUtils.GetRectanglesFromFile("assets/test_input.txt");
            Assert.AreEqual(10, rectangles.Count);
        }
    }
}