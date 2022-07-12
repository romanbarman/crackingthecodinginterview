using Contracts;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_11_Get_Random_Node : BaseQuestion
    {
        public override string GetDescription()
        {
            return "You are writing a binary search tree class from scratch that, in addition to insertion, search, and deletion methods, "
                + "contains a getRandomNode() method to get a random node in the tree. "
                + "The probability of selecting all nodes must be the same. "
                + "Design and implement the getRandomNode algorithm.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[] { new GetRandomNode.Solution() };
        }
    }
}
