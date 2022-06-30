using Contracts;
using Structures;
using System;
using System.Collections.Generic;

namespace Chapter04.CreateListsFromTree
{
    public class Solution : ISolution
    {
        private readonly BinaryTreeSearch<int> tree;

        public Solution(BinaryTreeSearch<int> tree)
        {
            this.tree = tree;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Binary Tree");
            tree.Show();

            var lists = new List<List<int>>();
            CreateLists(lists, tree.Root, 0);

            Console.WriteLine("Result");

            for (var level = 0; level < lists.Count; level++)
            {
                Console.WriteLine($"Level {level + 1}: {string.Join(", ", lists[level])}");
            }
        }

        private void CreateLists(List<List<int>> lists, BinaryTreeSearch<int>.Node node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (lists.Count < level + 1)
            {
                lists.Add(new List<int>());
            }

            lists[level].Add(node.Value);

            CreateLists(lists, node.Left, level + 1);
            CreateLists(lists, node.Right, level + 1);
        }
    }
}
