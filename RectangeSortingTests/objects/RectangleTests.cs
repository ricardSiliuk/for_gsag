using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectangeSorting.objects.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void AssertCorrectRectangeTypes()
        {
            Assert.AreEqual(RectangleType.Square, new Rectangle(1, 1).RectangleType);
            Assert.AreEqual(RectangleType.Flat, new Rectangle(2, 1).RectangleType);
            Assert.AreEqual(RectangleType.Tall, new Rectangle(1, 2).RectangleType);
        }

        [TestMethod()]
        public void AssertCalculatesAreaCorrectly()
        {
            Assert.AreEqual(25, new Rectangle(5,5).GetArea());
        }
    }
}