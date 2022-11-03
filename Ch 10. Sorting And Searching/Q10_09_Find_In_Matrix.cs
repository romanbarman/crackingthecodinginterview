using Contracts;
using System.Collections.Generic;

namespace Chapter10
{
    public class Q10_09_Find_In_Matrix : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new FindInMatrix.Solution(new int[,]
            {
                { 15, 20, 40, 85 },
                { 20, 35, 80, 95 },
                { 30, 55, 95, 105 },
                { 40, 80, 100, 120 }
            }, 55)
        };

        public override string GetDescription()
        {
            return "For a given matrix MxN, in which each row and column is sorted in ascending order, "
                + "write a method for finding an element.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
