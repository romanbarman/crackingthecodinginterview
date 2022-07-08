using Contracts;
using Structures.Interfaces;
using System;

namespace Chapter04.FindParent
{
    public abstract class BaseSolution : ISolution
    {
        protected readonly IBinaryTreeNode<int> Root;
        protected readonly IBinaryTreeNode<int> Node1;
        protected readonly IBinaryTreeNode<int> Node2;

        protected BaseSolution(IBinaryTreeNode<int> root, IBinaryTreeNode<int> node1, IBinaryTreeNode<int> node2)
        {
            Root = root;
            Node1 = node1;
            Node2 = node2;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            Console.WriteLine("Binary Tree");
            Root.Show();
            Console.WriteLine($"Node 1 -> {Node1.Value}");
            Console.WriteLine($"Node 2 -> {Node2.Value}");
            Console.WriteLine($"Parent -> {FindParent().Value}");
        }

        protected abstract IBinaryTreeNode<int> FindParent();
    }
}
