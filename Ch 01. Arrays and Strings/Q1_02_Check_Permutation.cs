using Contracts;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_02_Check_Permutation : BaseQuestion
    {
        private static string[][] pairs = new string[][]
        {
            new [] { "god", "dog"},
            new [] { "description", "scriptiondi"},
            new [] { "permutation", "mutationper"},
        };

        private ISolution[] solutions = new ISolution[]
        {
            new CheckPermutation.Solution1.Solution(pairs),
            new CheckPermutation.Solution2.Solution(pairs),
        };

        public override string GetDescription()
        {
            return "For two strings, write a method to determine if one string is a permutation of the other.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
