using Contracts;
using Structures.Interfaces;
using System;

namespace Chapter04.FindRoutes
{
    public class Solution : ISolution
    {
        private readonly IBinaryTreeNode<int> tree;
        private readonly int sum;

        public Solution(IBinaryTreeNode<int> tree, int sum)
        {
            this.tree = tree;
            this.sum = sum;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Sum: {sum}");
            tree.Show();
            Console.WriteLine($"CountPath -> {CountPath(tree)}");
        }

        private int CountPath(IBinaryTreeNode<int> root)
        {
            if (root == null)
            {
                return 0;
            }

            var pathsFromRoot = CountPathsWithSumFromNode(root, 0);
            var pathsOnLeft = CountPath(root.Left);
            var pathsOnRight = CountPath(root.Right);

            return pathsFromRoot + pathsOnLeft + pathsOnRight;
        }

        private int CountPathsWithSumFromNode(IBinaryTreeNode<int> node, int currentSum)
        {
            if (node == null)
            {
                return 0;
            }

            currentSum += node.Value;
            var totalPaths = 0;

            if (currentSum == sum)
            {
                totalPaths++;
            }

            totalPaths += CountPathsWithSumFromNode(node.Left, currentSum);
            totalPaths += CountPathsWithSumFromNode(node.Right, currentSum);

            return totalPaths;
        }
    }
}
