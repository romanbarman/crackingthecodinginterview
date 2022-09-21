using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_04_Subsets : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new Subsets.Solution(new List<int> {1, 2, 3, 4 , 5})
        };

        public override string GetDescription()
        {
            return "Write a method that returns all subsets of a given set.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
