using Contracts;
using Structures;
using Structures.Interfaces;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_05_Is_Binary_Tree_Search : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Implement a function to check if a binary tree is a binary search tree.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[]
            {
                new IsBinaryTreeSearch.Solution(new List<IBinaryTreeNode<int>> { CreateBinarySearchTree(), CreateBinaryTree() })
            };
        }

        private static IBinaryTreeNode<int> CreateBinarySearchTree()
        {
            var tree = new BinaryTreeSearch<int>();

            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(2);
            tree.Add(7);
            tree.Add(12);
            tree.Add(17);
            tree.Add(9);
            tree.Add(19);

            return tree.Root;
        }

        private static IBinaryTreeNode<int> CreateBinaryTree()
        {
            var tree = new BinaryTreeNode<int>(20);

            tree.SetLeft(new BinaryTreeNode<int>(10));
            tree.SetRight(new BinaryTreeNode<int>(30));
            tree.Left.SetRight(new BinaryTreeNode<int>(25));

            return tree;
        }
    }
}
