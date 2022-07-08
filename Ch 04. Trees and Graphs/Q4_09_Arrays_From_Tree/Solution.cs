using Contracts;
using Structures;
using Structures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter04.ArraysFromTree
{
    public class Solution : ISolution
    {
        private readonly IBinaryTreeNode<int> root;

        public Solution(IBinaryTreeNode<int> root)
        {
            this.root = root;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Binary Tree");
            root.Show();

            var nodesByLevel = new List<List<int>>();
            CreateLists(nodesByLevel, root, 0);

            Console.WriteLine();
            Console.WriteLine("Results");

            var i = 1;
            foreach (var combination in CreateCombinations(nodesByLevel))
            {
                Console.WriteLine();
                Console.WriteLine($"Array {i}: {string.Join(", ", combination)}");
                Console.WriteLine("Check");
                CreateBinaryTreeSearch(combination).Show();
                i++;
            }

        }

        private IBinaryTreeNode<int> CreateBinaryTreeSearch(List<int> elements)
        {
            var tree = new BinaryTreeSearch<int>();

            foreach (var item in elements)
            {
                tree.Add(item);
            }

            return tree.Root;
        }

        private List<List<int>> CreateCombinations(List<List<int>> nodesByLevel)
        {
            var result = new List<List<int>>();

            foreach (var level in nodesByLevel)
            {
                var levelCombinations = CreateLevelCombinations(level);
                var newResult = new List<List<int>>();

                if (result.Count == 0)
                {
                    result = levelCombinations;
                    continue;
                }

                foreach (var item in result)
                {
                    foreach (var combination in levelCombinations)
                    {
                        var newCombination = new List<int>();
                        newCombination.AddRange(item);
                        newCombination.AddRange(combination);

                        newResult.Add(newCombination);
                    }
                }

                result = newResult;
            }

            return result;
        }

        private List<List<int>> CreateLevelCombinations(List<int> nodes)
        {
            var result = new List<List<int>>();

            if (nodes.Count == 1)
            {
                result.Add(nodes);
                return result;
            }

            result.Add(nodes);

            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = i + 1; j < nodes.Count; j++)
                {
                    var tempList = nodes.ToList();
                    var tmp = tempList[i];
                    tempList[i] = tempList[j];
                    tempList[j] = tmp;

                    result.Add(tempList);
                }
            }

            return result;
        }

        private void CreateLists(List<List<int>> lists, IBinaryTreeNode<int> node, int level)
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
