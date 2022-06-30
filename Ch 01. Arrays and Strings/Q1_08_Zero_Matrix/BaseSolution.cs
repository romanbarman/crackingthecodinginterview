using Contracts;
using System;

namespace Chapter01.ZeroMatrix
{
    public abstract class BaseSolution : ISolution
    {
        private int[][] matrix;

        protected BaseSolution(int[][] matrix)
        {
            this.matrix = matrix;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            ShowMatrix(matrix);
            Console.WriteLine();
            Console.WriteLine("SetZero");
            Console.WriteLine("   |");
            Console.WriteLine("   V");
            Console.WriteLine();
            SetZero(matrix);
            ShowMatrix(matrix);
        }

        protected abstract void SetZero(int[][] matrix);

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
    }
}
