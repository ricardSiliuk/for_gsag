using RectangeSorting.objects;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace RectangeSorting.helpers
{
    public static class RectangleSortingUtils
    {
        public static List<Rectangle> GetRectanglesFromFile(string filename)
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            foreach (var line in File.ReadLines(filename))
            {
                // what should I throw in case file is badly formatted?
                var values = line.Split(" ");
                rectangles.Add(new Rectangle(Int32.Parse(values[0]), Int32.Parse(values[1])));
            }
            return rectangles;
        }

        public static double GetPercentOfSquares(IEnumerable<Rectangle> rectangles)
        {
            return ((double)rectangles.Where(x => x.RectangleType == RectangleType.Square).Count() / rectangles.Count()) * 100;
        }
    }
}
