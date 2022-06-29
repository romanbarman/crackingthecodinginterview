using Contracts;
using Structures;
using System;

namespace Chapter04.CreateTreeFromArray
{
    public class Solution : ISolution
    {
        private readonly int[] array;

        public Solution(int[] array)
        {
            this.array = array;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Array: {string.Join(", ", array)}");
            var tree = CreateTree();
            Console.WriteLine("Binary tree");
            ShowTree(tree.Root);
        }

        private void ShowTree(BinaryTree<int>.Node node)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left == null && node.Right == null)
            {
                return;
            }

            Console.WriteLine($"{node.Value}: Left -> {node.Left?.Value} Right -> {node.Right?.Value}");
            ShowTree(node.Left);
            ShowTree(node.Right);
        }

        private BinaryTree<int> CreateTree()
        {
            var tree = new BinaryTree<int>();

            if (array.Length == 1)
            {
                tree.Add(array[0]);
                return tree;
            }

            if (array.Length == 2)
            {
                tree.Add(array[0]);
                tree.Add(array[1]);
                return tree;
            }

            var middleIndex = array.Length % 2 == 0 ? array.Length / 2 - 1 : array.Length / 2;
            tree.Add(array[middleIndex]);
            Add(0, middleIndex - 1, tree);
            Add(middleIndex + 1, array.Length - 1, tree);

            return tree;
        }

        private void Add(int startIndex, int endIndex, BinaryTree<int> tree)
        {
            if (startIndex == endIndex)
            {
                tree.Add(array[startIndex]);
                return;
            }

            if (endIndex - startIndex == 1)
            {
                tree.Add(array[startIndex]);
                tree.Add(array[endIndex]);
                return;
            }

            var length = endIndex - startIndex + 1;
            var middleIndex = length % 2 == 0 ? startIndex + (length / 2 - 1) : startIndex + length / 2;
            tree.Add(array[middleIndex]);
            Add(startIndex, middleIndex - 1, tree);
            Add(middleIndex + 1, endIndex, tree);
        }
    }
}
