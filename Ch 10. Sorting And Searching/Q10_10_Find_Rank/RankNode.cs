namespace Chapter10.FindRank
{
    public class RankNode
    {
        private int leftSize;
        private RankNode left;
        private RankNode right;
        private int data;

        public RankNode(int data)
        {
            this.data = data;
        }

        public void Insert(int data)
        {
            if (data <= this.data)
            {
                if (left != null)
                    left.Insert(data);
                else
                    left = new RankNode(data);
                leftSize++;
            }
            else
            {
                if (right != null)
                    right.Insert(data);
                else
                    right = new RankNode(data);
            }
        }

        public int GetRank(int data)
        {
            if (data == this.data)
                return leftSize;

            if (data < this.data)
            {
                return left == null ? -1 : left.GetRank(data);
            }
            else
            {
                var rightRank = right == null ? -1 : right.GetRank(data);

                return rightRank == -1 ? -1 : leftSize + 1 + rightRank;
            }
        }
    }
}
