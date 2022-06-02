using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_08_Zero_Matrix : IQuestion
    {
        public string GetDescription()
        {
            return "Write an algorithm that implements the following condition: " +
                "if the element of the matrix MxN is equal to 0, then the entire column and the entire row are set to zero.";
        }

        public void Run()
        {
            var matrix = new int[][]
            {
                new [] {1,2,3,4,5},
                new [] {1,0,3,4,5},
                new [] {1,2,3,4,5},
                new [] {1,2,3,4,0}
            };

            ShowMatrix(matrix);

            Console.WriteLine("SetZero ->");
            SetZero(matrix);
            ShowMatrix(matrix);
        }

        private void ShowMatrix(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }

                Console.WriteLine();
            }
        }

        private void SetZero(int[][] matrix)
        {
            var zeroPositions = GetZeroPositions(matrix);
            SetZero(zeroPositions, matrix);
        }

        private void SetZero(IList<(int, int)> zeroPositions, int[][] matrix)
        {
            foreach (var position in zeroPositions)
            {
                matrix[position.Item1] = new int[matrix[0].Length];

                for (var i = 0; i < matrix.Length; i++)
                {
                    matrix[i][position.Item2] = 0;
                }
            }
        }

        private IList<(int, int)> GetZeroPositions(int[][] matrix)
        {
            var result = new List<(int, int)>();

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        result.Add((i, j));
                    }
                }
            }

            return result;
        }
    }
}
