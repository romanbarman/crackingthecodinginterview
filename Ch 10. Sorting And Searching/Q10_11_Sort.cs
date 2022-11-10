using Contracts;
using System.Collections.Generic;

namespace Chapter10
{
    public class Q10_11_Sort : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new Sort.Solution(new int[] { 1, 2, 3, 4, 5, 6 })
        };

        public override string GetDescription()
        {
            return "There is an array of integers. "
                + "We will call a peak an element that is greater than neighboring elements or equal to them, "
                + "and a trough is an element that is less than neighboring elements or equal to them. "
                + "Sort an array of integers into alternating sequences of peaks and troughs.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
