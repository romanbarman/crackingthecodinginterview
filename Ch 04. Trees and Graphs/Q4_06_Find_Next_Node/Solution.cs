using Contracts;
using Structures.Interfaces;
using System;

namespace Chapter04.FindNextNode
{
    public class Solution : ISolution
    {
        private readonly IBinaryTreeNode<int> tree;
        private readonly IBinaryTreeNode<int> node;

        public Solution(IBinaryTreeNode<int> tree, IBinaryTreeNode<int> node)
        {
            this.tree = tree;
            this.node = node;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            tree.Show();
            Console.WriteLine($"InorderSucc({node.Value}) -> {InorderSucc()?.Value}");
        }

        private IBinaryTreeNode<int> InorderSucc()
        {
            if (node.Right != null)
            {
                return LeftMostChild(node.Right);
            }
            else
            {
                var q = node;
                var x = q.Parent;

                while (x != null && x.Left != q)
                {
                    q = x;
                    x = x.Parent;
                }

                return x;
            }
        }

        private IBinaryTreeNode<int> LeftMostChild(IBinaryTreeNode<int> n)
        {
            if (n == null)
            {
                return null;
            }

            while (n.Left != null)
            {
                n = n.Left;
            }

            return n;
        }
    }
}
