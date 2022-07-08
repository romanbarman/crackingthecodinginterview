using Contracts;
using Structures;
using Structures.Interfaces;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_08_Find_Parent : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Create an algorithm and code to find the first common ancestor of two nodes in a binary tree. "
                + "Try to avoid storing additional nodes in the data structure. "
                + "The binary tree is not necessarily a binary search tree.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            var root = CreateTree();

            return new ISolution[]
            {
                new FindParent.Solution1.Solution(root, root.Right.Left, root.Right.Right.Right),
                new FindParent.Solution2.Solution(root, root.Right.Left, root.Right.Left.Left)
            };
        }

        private IBinaryTreeNode<int> CreateTree()
        {
            var binaryTreeNode = new BinaryTreeNode<int>(1);

            binaryTreeNode.SetLeft(new BinaryTreeNode<int>(2));
            binaryTreeNode.SetRight(new BinaryTreeNode<int>(3));

            binaryTreeNode.Left.SetLeft(new BinaryTreeNode<int>(4));
            binaryTreeNode.Left.SetRight(new BinaryTreeNode<int>(5));

            binaryTreeNode.Right.SetLeft(new BinaryTreeNode<int>(6));
            binaryTreeNode.Right.SetRight(new BinaryTreeNode<int>(7));

            binaryTreeNode.Left.Left.SetLeft(new BinaryTreeNode<int>(8));
            binaryTreeNode.Left.Left.SetRight(new BinaryTreeNode<int>(9));

            binaryTreeNode.Left.Right.SetLeft(new BinaryTreeNode<int>(10));
            binaryTreeNode.Left.Right.SetRight(new BinaryTreeNode<int>(11));

            binaryTreeNode.Right.Left.SetLeft(new BinaryTreeNode<int>(12));
            binaryTreeNode.Right.Left.SetRight(new BinaryTreeNode<int>(13));

            binaryTreeNode.Right.Right.SetLeft(new BinaryTreeNode<int>(14));
            binaryTreeNode.Right.Right.SetRight(new BinaryTreeNode<int>(15));

            return binaryTreeNode;
        }
    }
}
