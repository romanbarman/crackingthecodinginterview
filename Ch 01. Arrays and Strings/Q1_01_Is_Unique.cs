using Contracts;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_01_Is_Unique : BaseQuestion
    {
        private static readonly string[] strCollection = new[] { "hello", "world", "car", "google" };
        private ISolution[] solutions = new ISolution[]
        {
            new IsUnique.Solution1.Solution(strCollection),
            new IsUnique.Solution2.Solution(strCollection),
            new IsUnique.Solution3.Solution(strCollection),
            new IsUnique.Solution4.Solution(strCollection)
        };

        public override string GetDescription()
        {
            return "Implement an algorithm that determines whether all characters in a string occur only once. "
                + "And if it is forbidden to use additional data structures?";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
