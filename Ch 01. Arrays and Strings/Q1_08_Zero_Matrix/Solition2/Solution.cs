namespace Chapter01.ZeroMatrix.Solition2
{
    public class Solution : BaseSolution
    {
        public Solution(int[][] matrix) : base(matrix) { }

        public override string GetComment()
        {
            return "No additional memory.";
        }

        protected override void SetZero(int[][] matrix)
        {
            var rowHasZero = HasFirstRowZero(matrix);
            var columnHasZero = HasFirstColumnZero(matrix);

            CheckNull(matrix);
            SetZeroRows(matrix);
            SetZeroColumns(matrix);

            if (rowHasZero)
            {
                SetZeroRow(matrix, 0);
            }

            if (columnHasZero)
            {
                SetZeroColumn(matrix, 0);
            }
        }

        private void SetZeroRow(int[][] matrix, int row)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                matrix[row][j] = 0;
            }
        }

        private void SetZeroColumn(int[][] matrix, int column)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                matrix[i][column] = 0;
            }
        }

        private void SetZeroColumns(int[][] matrix)
        {
            for (var j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0)
                {
                    SetZeroColumn(matrix, j);
                }
            }
        }

        private void SetZeroRows(int[][] matrix)
        {
            for (var i = 1; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    SetZeroRow(matrix, i);
                }
            }
        }

        private void CheckNull(int[][] matrix)
        {
            for (var i = 1; i < matrix.Length; i++)
            {
                for (var j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }
        }

        private bool HasFirstColumnZero(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool HasFirstRowZero(int[][] matrix)
        {
            for (var i = 0; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
