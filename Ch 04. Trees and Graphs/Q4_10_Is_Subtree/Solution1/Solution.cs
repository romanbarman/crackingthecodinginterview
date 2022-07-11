using Structures.Interfaces;

namespace Chapter04.IsSubtree.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(IBinaryTreeNode<int> t1, IBinaryTreeNode<int> t2) : base(t1, t2) { }

        public override string GetComment()
        {
            return "Alternate solution.";
        }

        protected override bool HasSubTree()
        {
            return HasSubTree(T1);
        }

        private bool HasSubTree(IBinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Value == T2.Value && IsEqual(root, T2))
            {
                return true;
            }

            return HasSubTree(root.Left) || HasSubTree(root.Right);
        }

        private bool IsEqual(IBinaryTreeNode<int> t1Node, IBinaryTreeNode<int> t2Node)
        {
            if (t1Node == null && t2Node == null)
            {
                return true;
            }

            if (t1Node != null && t2Node != null)
            {
                return t1Node.Value == t2Node.Value && IsEqual(t1Node.Left, t2Node.Left) && IsEqual(t1Node.Right, t2Node.Right);
            }

            return false;
        }
    }
}
