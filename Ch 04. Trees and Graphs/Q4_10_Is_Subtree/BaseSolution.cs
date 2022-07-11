using Contracts;
using Structures.Interfaces;
using System;

namespace Chapter04.IsSubtree
{
    public abstract class BaseSolution : ISolution
    {
        protected readonly IBinaryTreeNode<int> T1;
        protected readonly IBinaryTreeNode<int> T2;

        protected BaseSolution(IBinaryTreeNode<int> t1, IBinaryTreeNode<int> t2)
        {
            T1 = t1;
            T2 = t2;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("T1: ");
            T1.Show();
            Console.WriteLine();
            Console.WriteLine("T2: ");
            T2.Show();

            Console.WriteLine();
            Console.WriteLine($"HasSubTree -> {HasSubTree()}");
        }

        protected abstract bool HasSubTree();
    }
}
