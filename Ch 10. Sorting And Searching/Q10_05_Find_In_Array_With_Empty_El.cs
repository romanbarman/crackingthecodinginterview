using Contracts;
using System.Collections.Generic;

namespace Chapter10
{
    public class Q10_05_Find_In_Array_With_Empty_El : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new FindInArrayWithEmptyEl.Solution(new [] { "at", "", "", "", "ball", "", "", "car", "", "", "dad", "", ""}, "dad")
        };

        public override string GetDescription()
        {
            return "There is a sorted array of strings that may contain empty strings. "
                + "Write a method to determine the position of a given string.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
