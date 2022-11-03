using System;

namespace Chapter10.FindInMatrix
{
    public class Coordinate : ICloneable
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public bool IsInBounds(int[,] matrix)
        {
            return Row >= 0 && Column >= 0 && Row < matrix.GetLength(0) && Column < matrix.GetLength(1);
        }

        public bool IsBefore(Coordinate p)
        {
            return Row <= p.Row && Column <= p.Column;
        }

        public object Clone()
        {
            return new Coordinate(Row, Column);
        }

        public void SetToAverage(Coordinate min, Coordinate max)
        {
            Row = (min.Row + max.Row) / 2;
            Column = (min.Column + max.Column) / 2;
        }
    }
}
