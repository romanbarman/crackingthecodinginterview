using System.Collections.Generic;

namespace Chapter01.ZeroMatrix.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(int[][] matrix) : base(matrix) { }

        public override string GetComment()
        {
            return "Additional memory is being used.";
        }

        protected override void SetZero(int[][] matrix)
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
