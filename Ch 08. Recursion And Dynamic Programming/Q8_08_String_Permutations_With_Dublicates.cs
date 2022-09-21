using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_08_String_Permutations_With_Dublicates : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new StringPermutationsWithDublicates.Solution("abca")
        };

        public override string GetDescription()
        {
            return "Write a method to calculate all permutations of a string whose characters do not have to be unique. "
                + "There should be no duplicates in the list of permutations.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
