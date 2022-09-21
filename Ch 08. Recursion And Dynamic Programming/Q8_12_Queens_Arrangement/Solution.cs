using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter08.QueensArrangement
{
    public class Solution : ISolution
    {
        private const int GridSize = 8;

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            var results = new List<int[]>();
            PlaceQueens(0, new int[GridSize], results);

            foreach (var result in results)
            {
                Console.WriteLine($"{string.Join("; ", result.Select((val, index) => $"{val}-{index}"))}");
            }
        }

        private void PlaceQueens(int row, int[] columns, List<int[]> results)
        {
            if (row == GridSize)
            {
                results.Add(columns.ToArray());
            }
            else
            {
                for (int column = 0; column < GridSize; column++)
                {
                    if (CheckValid(columns, row, column))
                    {
                        columns[row] = column;
                        PlaceQueens(row + 1, columns, results);
                    }
                }
            }
        }

        private bool CheckValid(int[] columns, int row1, int column1)
        {
            for (int row2 = 0; row2 < row1; row2++)
            {
                var column2 = columns[row2];

                if (column1 == column2)
                {
                    return false;
                }

                var columnDistance = Math.Abs(column2 - column1);

                var rowDistance = row1 - row2;

                if (columnDistance == rowDistance)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
