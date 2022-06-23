using Contracts;
using System;

namespace Chapter01.RotateMatrix
{
    public abstract class BaseSolution : ISolution
    {
        private int[,] matrix;

        protected BaseSolution(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            ShowMatrix(matrix);
            Console.WriteLine("Rotate");
            Console.WriteLine("  |");
            Console.WriteLine("  V");
            Console.WriteLine();
            ShowMatrix(Rotate(matrix));
        }

        protected abstract int[,] Rotate(int[,] image);

        private void ShowMatrix(int[,] matrix)
        {
            var n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j].ToString().PadRight(4));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
