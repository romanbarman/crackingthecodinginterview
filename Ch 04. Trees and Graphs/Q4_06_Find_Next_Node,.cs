using Contracts;
using Structures;
using Structures.Interfaces;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_06_Find_Next_Node : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Write an algorithm for finding the \"next\" node for the posterior node in the binary search tree. "
                + "Consider that each node has a link to its parent.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            var tree = CreateTree();
            return new ISolution[] { new FindNextNode.Solution(tree, tree.Right.Right) };
        }

        private IBinaryTreeNode<int> CreateTree()
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
    }
}
