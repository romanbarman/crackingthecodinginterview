using Contracts;
using Structures;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_03_Create_Lists_From_Tree : BaseQuestion
    {
        public override string GetDescription()
        {
            return "For a binary tree, develop an algorithm that creates a linked list of all nodes at each depth.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            var tree = new BinaryTreeSearch<int>();

            tree.Add(10);
            tree.Add(15);
            tree.Add(5);
            tree.Add(17);
            tree.Add(7);
            tree.Add(12);
            tree.Add(2);
            tree.Add(19);
            tree.Add(9);

            return new ISolution[] { new CreateListsFromTree.Solution(tree) };
        }
    }
}
