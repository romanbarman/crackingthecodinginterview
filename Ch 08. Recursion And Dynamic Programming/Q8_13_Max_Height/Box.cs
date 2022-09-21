using System;
using System.Diagnostics.CodeAnalysis;

namespace Chapter08.MaxHeight
{
    public class Box : IComparable<Box>
    {
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }

        public Box(double height, double width, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

        public int CompareTo(Box other)
        {
            var result = Height.CompareTo(other.Height);

            if (result == 0)
            {
                return 0;
            }
            
            if (result > 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public bool CanBeAbove(Box box)
        {
            return Height < box.Height && Width < box.Width && Depth < box.Depth;
        }
    }
}
