using Structures.Interfaces;

namespace Chapter04.FindParent.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(IBinaryTreeNode<int> root, IBinaryTreeNode<int> node1, IBinaryTreeNode<int> node2) : base(root, node1, node2) { }

        public override string GetComment()
        {
            return "No references to parents.";
        }

        protected override IBinaryTreeNode<int> FindParent()
        {
            if (!Covers(Root, Node1) || !Covers(Root, Node2))
            {
                return null;
            }

            return ParentHelper(Root);
        }

        private IBinaryTreeNode<int> ParentHelper(IBinaryTreeNode<int> root)
        {
            if (root == null || root == Node1 || root == Node2)
            {
                return root;
            }

            var node1IsOnLeft = Covers(root.Left, Node1);
            var node2IsOnLeft = Covers(root.Left, Node2);

            if (node1IsOnLeft != node2IsOnLeft)
            {
                return root;
            }

            var childSide = node1IsOnLeft ? root.Left : root.Right;
            return ParentHelper(childSide);
        }


        private bool Covers(IBinaryTreeNode<int> root, IBinaryTreeNode<int> node)
        {
            if (root == null)
            {
                return false;
            }

            if (root == node)
            {
                return true;
            }

            return Covers(root.Left, node) || Covers(root.Right, node);
        }
    }
}
