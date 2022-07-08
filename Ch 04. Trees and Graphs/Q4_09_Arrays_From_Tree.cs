using Contracts;
using Structures;
using Structures.Interfaces;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_09_Arrays_From_Tree : BaseQuestion
    {
        public override string GetDescription()
        {
            return "The binary search tree was created by traversing the array from left to right and inserting each element. "
                + "Given a binary search tree with different elements, print all possible arrays that could lead to the creation of this tree.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[] { new ArraysFromTree.Solution(CreateTree()) };
        }

        private IBinaryTreeNode<int> CreateTree()
        {
            var tree = new BinaryTreeSearch<int>();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(2);
            tree.Add(7);
            tree.Add(9);

            return tree.Root;
        }
    }
}
