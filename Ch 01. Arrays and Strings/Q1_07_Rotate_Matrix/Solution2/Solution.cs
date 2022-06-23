namespace Chapter01.RotateMatrix.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(int[,] matrix) : base(matrix) { }

        public override string GetComment()
        {
            return "Without additional memory.";
        }

        protected override int[,] Rotate(int[,] image)
        {
            var n = image.GetLength(0);
            var layersCount = image.Length / 2;

            for (var layer = 0; layer < layersCount; layer++)
            {
                for (var i = layer; i < n - layer - 1; i++)
                {
                    var tmp = image[layer,i];

                    image[layer,i] = image[n - i - 1,layer];
                    image[n - i - 1,layer] = image[n - layer - 1,n - i - 1];
                    image[n - layer - 1,n - i - 1] = image[i,n - layer - 1];
                    image[i,n - layer - 1] = tmp;
                }
            }

            return image;
        }
    }
}
