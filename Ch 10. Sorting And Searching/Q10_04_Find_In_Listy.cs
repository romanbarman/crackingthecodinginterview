using Contracts;
using System.Collections.Generic;

namespace Chapter10
{
    public class Q10_04_Find_In_Listy : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new FindInListy.Solution(new FindInListy.Listy(new [] { 2, 2, 4, 6, 8, 8, 10, 12, 14, 14 }), 10)
        };

        public override string GetDescription()
        {
            return "There is a Listy data structure - an analogue of an array, "
                + "in which there is no method for determining the size. "
                + "It also supports the elementAt(i) method, which returns the element at index i. "
                + "If the value of i is outside the bounds of the data structure, the method returns -1. "
                + "Given a Listy instance containing sorted positive numbers, "
                + "find the index of the element with the given x value.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
