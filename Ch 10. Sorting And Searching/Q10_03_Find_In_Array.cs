using Contracts;
using System.Collections.Generic;

namespace Chapter10
{
    public class Q10_03_Find_In_Array : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new FindInArray.Solution(new [] { 2, 2, 2, 3, 4, 2 }, 4)
        };


        public override string GetDescription()
        {
            return "There is a sorted array of n integers that has been rotated an unknown number of times. "
                + "Write code to find an element in an array. "
                + "It is assumed that the array was originally sorted in ascending order.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
