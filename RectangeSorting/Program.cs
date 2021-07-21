using RectangeSorting.helpers;
using System.Linq;
using System;

namespace RectangeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangles = RectangleSortingUtils.GetRectanglesFromFile("../../../input.txt");
            foreach (var rectangle in rectangles.OrderBy(item => item.Diagonal))
            {
                Console.WriteLine($"{rectangle.GetArea()}, {rectangle.RectangleType}");
            }
            Console.WriteLine($"{RectangleSortingUtils.GetPercentOfSquares(rectangles)}");
        }
    }
}
