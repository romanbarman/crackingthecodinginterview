namespace Chapter08.MagicIndex.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(int[] array) : base(array) { }

        public override string GetComment()
        {
            return "When the array contains unique numbers.";
        }

        protected override int GetMagicIndex()
        {
            var start = 0;
            var end = Array.Length - 1;
            var midlle = Array.Length / 2;

            while (true)
            {
                if (Array[midlle] == midlle)
                {
                    return midlle;
                }

                if (Array[midlle] < midlle)
                {
                    start = midlle + 1;
                }
                else
                {
                    end = midlle - 1;
                }

                var tempMiddle = (start + end) / 2;

                if (tempMiddle == midlle)
                {
                    return -1;
                }

                midlle = tempMiddle;
            }
        }
    }
}
