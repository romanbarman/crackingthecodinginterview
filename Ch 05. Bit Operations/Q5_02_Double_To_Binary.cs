using Contracts;
using System.Collections.Generic;

namespace Chapter05
{
    public class Q5_02_Double_To_Binary : BaseQuestion
    {
        private readonly ISolution[] solutions = new ISolution[]
        {
            new DoubleToBinary.Solution(new [] { 0.25, 0.72 })
        };

        public override string GetDescription()
        {
            return "You are given a real number between 0 and 1, which is transmitted in double format. "
                + "Output its binary representation. "
                + "If the exact binary representation of a number is not 32 bits long, print an error message";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
