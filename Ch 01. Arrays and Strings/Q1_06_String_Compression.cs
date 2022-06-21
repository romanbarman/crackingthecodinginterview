using Contracts;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_06_String_Compression : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new StringCompression.Solution(new[] { "aabcccccaaad", "abcd", "aabbc" })
        };

        public override string GetDescription()
        {
            return "Implement a method to perform basic string compression using a repeated character count. "
                + "If the compressed string does not become shorter than the original string, then the method returns the original string.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
