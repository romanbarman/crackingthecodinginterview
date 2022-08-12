using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_07_String_Permutations : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new StringPermutations.Solution("abcd")
        };

        public override string GetDescription()
        {
            return "Write a method to calculate all permutations of a string consisting of unique characters.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
