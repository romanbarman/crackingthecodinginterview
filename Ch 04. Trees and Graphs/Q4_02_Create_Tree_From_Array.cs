using Contracts;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_02_Create_Tree_From_Array : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new CreateTreeFromArray.Solution(new[] { 1, 2, 3, 4, 5, 6, 7, 8 })
        };

        public override string GetDescription()
        {
            return "Write an algorithm for creating a binary search tree with a minimum height for a sorted array with unique integer elements.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
