using Contracts;
using System.Collections.Generic;

namespace Chapter10
{
    public class Q10_10_Find_Rank : BaseQuestion
    {
        private ISolution[] solutions = new ISolution[]
        {
            new FindRank.Solution(new [] { 20, 15, 25, 10, 23, 5, 13, 24 }, 24)
        };

        public override string GetDescription()
        {
            return "You are processing a stream of integers. Periodically, you need to find the rank of x. "
                + "Implement the track(int x) method, which is called when generating each character, "
                + "and the getRankOfNumber(int x) method, which returns the number of values < x.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
