namespace Chapter01.RotateMatrix.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(int[,] matrix) : base(matrix) { }

        public override string GetComment()
        {
            return "Used additional memory.";
        }

        protected override int[,] Rotate(int[,] image)
        {
            var n = image.GetLength(0);
            var result = new int[n, n];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    result[j, n - i - 1] = image[i,j];
                }
            }

            return result;
        }
    }
}
