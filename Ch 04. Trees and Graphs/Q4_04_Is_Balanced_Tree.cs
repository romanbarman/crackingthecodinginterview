using Contracts;
using Structures;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_04_Is_Balanced_Tree : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Implement a function that checks the balance of a binary tree. "
                + "We consider a tree to be balanced if the height difference between two subtrees of any node does not exceed 1.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[]
            {
                new IsBalancedTree.Solution(new List<BinaryTreeSearch<int>> { CreateBalancedTree(), CreateNotBalancedTree() })
            };
        }

        private static BinaryTreeSearch<int> CreateBalancedTree()
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

            return tree;
        }

        private static BinaryTreeSearch<int> CreateNotBalancedTree()
        {
            var tree = new BinaryTreeSearch<int>();

            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(7);
            tree.Add(12);
            tree.Add(17);
            tree.Add(9);
            tree.Add(19);

            return tree;
        }
    }
}
