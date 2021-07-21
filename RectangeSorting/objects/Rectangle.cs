using System;

namespace RectangeSorting.objects
{
    public class Rectangle
    {
        public int Length { get; }
        public int Width { get; }
        public double Diagonal { get; }

        public RectangleType RectangleType { get; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
            Diagonal = Math.Sqrt(length * length + width * width);
            if (Width > Length)
            {
                RectangleType = RectangleType.Tall;
            }
            else if (Width < Length) {
                RectangleType = RectangleType.Flat;
            }
            else
            {
                RectangleType = RectangleType.Square;
            }
        }

        public int GetArea()
        {
            return Length * Width;
        }

    }
}
