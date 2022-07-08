using Structures.Interfaces;
using System;

namespace Chapter04.FindParent.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(IBinaryTreeNode<int> root, IBinaryTreeNode<int> node1, IBinaryTreeNode<int> node2) : base(root, node1, node2) { }

        public override string GetComment()
        {
            return "With links to ancestors.";
        }

        protected override IBinaryTreeNode<int> FindParent()
        {
            var delta = Depth(Node1) - Depth(Node2);
            var first = delta > 0 ? Node2 : Node1;
            var second = delta > 0 ? Node1 : Node2;

            second = GoUpBy(second, Math.Abs(delta));

            while (first != second && first != null && second != null)
            {
                first = first.Parent;
                second = second.Parent;
            }

            return first == null || second == null ? null : first;
        }

        private IBinaryTreeNode<int> GoUpBy(IBinaryTreeNode<int> node, int delta)
        {
            while (delta > 0 && node != null)
            {
                node = node.Parent;
                delta--;
            }

            return node;
        }

        private int Depth(IBinaryTreeNode<int> node)
        {
            int depth = 0;

            while (node != null)
            {
                node = node.Parent;
                depth++;
            }

            return depth;
        }
    }
}
