using Contracts;
using Structures.Interfaces;
using System;
using System.Collections.Generic;

namespace Chapter04.IsBinaryTreeSearch
{
    public class Solution : ISolution
    {
        private readonly IList<IBinaryTreeNode<int>> trees;

        public Solution(IList<IBinaryTreeNode<int>> trees)
        {
            this.trees = trees;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            foreach (var tree in trees)
            {
                Console.WriteLine();
                tree.Show();
                Console.WriteLine($"IsBinaryTreeSearch -> {IsBinaryTreeSearch(tree)}");
            }
        }

        private bool IsBinaryTreeSearch(IBinaryTreeNode<int> tree)
        {
            return IsBinaryTreeSearch(tree, null, null);
        }

        private bool IsBinaryTreeSearch(IBinaryTreeNode<int> tree, int? min, int? max)
        {
            if (tree == null)
            {
                return true;
            }

            if ((min.HasValue && tree.Value <= min) || (max.HasValue && tree.Value > max))
            {
                return false;
            }

            if (!IsBinaryTreeSearch(tree.Left, min, tree.Value) || !IsBinaryTreeSearch(tree.Right, tree.Value, max))
            {
                return false;
            }

            return true;
        }
    }
}
