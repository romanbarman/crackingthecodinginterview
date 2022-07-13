using Contracts;
using Structures;
using Structures.Interfaces;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_12_Find_Routes : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Given a binary tree in which each node contains an integer. "
                + "Develop an algorithm to count all paths whose sum equals a given value. "
                + "Note that the path does not have to start or end at the root or leaf node, but must go down.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[] { new FindRoutes.Solution(CreateTree(), 8) };
        }

        private IBinaryTreeNode<int> CreateTree()
        {
            var binaryTreeNode = new BinaryTreeNode<int>(10);

            binaryTreeNode.SetLeft(new BinaryTreeNode<int>(5));
            binaryTreeNode.SetRight(new BinaryTreeNode<int>(-3));

            binaryTreeNode.Left.SetLeft(new BinaryTreeNode<int>(3));
            binaryTreeNode.Left.SetRight(new BinaryTreeNode<int>(1));

            binaryTreeNode.Right.SetRight(new BinaryTreeNode<int>(11));

            binaryTreeNode.Left.Left.SetLeft(new BinaryTreeNode<int>(3));
            binaryTreeNode.Left.Left.SetRight(new BinaryTreeNode<int>(-2));

            binaryTreeNode.Left.Right.SetRight(new BinaryTreeNode<int>(2));

            binaryTreeNode.Left.Left.Right.SetRight(new BinaryTreeNode<int>(2));

            return binaryTreeNode;
        }
    }
}
