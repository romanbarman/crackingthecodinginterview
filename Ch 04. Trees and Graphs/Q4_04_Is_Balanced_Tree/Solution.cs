using Contracts;
using Structures;
using System;
using System.Collections.Generic;

namespace Chapter04.IsBalancedTree
{
    public class Solution : ISolution
    {
        private readonly IList<BinaryTreeSearch<int>> trees;

        public Solution(IList<BinaryTreeSearch<int>> trees)
        {
            this.trees = trees;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            foreach (var tree in trees)
            {
                Console.WriteLine();
                tree.Show();
                Console.WriteLine($"IsBalanced -> {IsBalanced(tree)}");
            }
        }

        private bool IsBalanced(BinaryTreeSearch<int> tree)
        {
            return GetHeight(tree.Root) != int.MinValue;
        }

        private int GetHeight(BinaryTreeSearch<int>.Node node)
        {
            if (node == null)
            {
                return 0;
            }

            var leftHeight = GetHeight(node.Left);
            var rightHeight = GetHeight(node.Right);

            if (leftHeight == int.MinValue || rightHeight == int.MinValue)
            {
                return int.MinValue;
            }

            if (Math.Abs(leftHeight - rightHeight) <= 1)
            {
                return Math.Max(leftHeight, rightHeight) + 1;
            }

            return int.MinValue;
        }
    }
}
