using Contracts;
using System;

namespace Chapter10.FindInMatrix
{
    public class Solution : ISolution
    {
        private readonly int[,] matrix;
        private readonly int element;

        public Solution(int[,] matrix, int element)
        {
            this.matrix = matrix;
            this.element = element;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Array:");
            ShowMatrix();
            Console.WriteLine($"Element: {element}");

            var result = FindElement();

            if (result != null)
                Console.WriteLine($"Index: {result.Row}, {result.Column}");
            else
                Console.WriteLine($"Index: -1, -1");
        }

        private void ShowMatrix()
        {
            var n = matrix.GetLength(0);
            var m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadRight(4));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        private Coordinate FindElement()
        {
            var origin = new Coordinate(0, 0);
            var dest = new Coordinate(matrix.GetLength(0) - 1, matrix.GetLength(1) - 1);

            return FindElement(origin, dest);
        }

        private Coordinate FindElement(Coordinate origin, Coordinate dest)
        {
            if (!origin.IsInBounds(matrix) || !dest.IsInBounds(matrix))
                return null;

            if (matrix[origin.Row, origin.Column] == element)
                return origin;
            else if (!origin.IsBefore(dest))
                return null;

            var start = origin.Clone() as Coordinate;
            var diagDist = Math.Min(dest.Row - origin.Row, dest.Column - origin.Column);
            var end = new Coordinate(start.Row + diagDist, start.Column + diagDist);
            var p = new Coordinate(0, 0);

            while (start.IsBefore(end))
            {
                p.SetToAverage(start, end);

                if (element > matrix[p.Row, p.Column])
                {
                    start.Row = p.Row + 1;
                    start.Column = p.Column + 1;
                }
                else
                {
                    end.Row = p.Row - 1;
                    end.Column = p.Column - 1;
                }
            }

            return PartitionAndSearch(origin, dest, start);
        }

        private Coordinate PartitionAndSearch(Coordinate origin, Coordinate dest, Coordinate pivot)
        {
            var lowerLeftOrigin = new Coordinate(pivot.Row, origin.Column);
            var lowerLeftDest = new Coordinate(dest.Row, pivot.Column - 1);
            var upperRightOrigin = new Coordinate(origin.Row, pivot.Column);
            var upperRightDest = new Coordinate(pivot.Row - 1, dest.Column);

            var lowerLeft = FindElement(lowerLeftOrigin, lowerLeftDest);

            if (lowerLeft == null)
                return FindElement(upperRightOrigin, upperRightDest);

            return lowerLeft;
        }
    }
}
