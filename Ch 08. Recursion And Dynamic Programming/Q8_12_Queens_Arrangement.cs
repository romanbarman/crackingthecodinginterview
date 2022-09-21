using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_12_Queens_Arrangement : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new QueensArrangement.Solution()
        };

        public override string GetDescription()
        {
            return "Write an algorithm that finds all options for placing eight queens on an 8x8 chessboard "
                + "so that no two pieces are located on the same horizontal, vertical, or diagonal.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
