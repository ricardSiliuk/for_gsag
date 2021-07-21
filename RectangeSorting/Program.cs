using RectangeSorting.helpers;
using System.Linq;
using System;

namespace RectangeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangles = HelperUtils.GetRectanglesFromFile("assets/input.txt");
            rectangles
                .OrderBy(item => item.Diagonal)
                .ToList()
                .ForEach(item => Console.WriteLine($"{item.GetArea()}, {item.RectangleType}"));
            Console.WriteLine($"{HelperUtils.GetPercentOfSquares(rectangles)}");
        }
    }
}
