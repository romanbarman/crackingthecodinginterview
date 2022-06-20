using Contracts;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_04_Palindrome_Permutation : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new PalindromePermutation.Solution(new []
            {
                "Rats live on no evil star",
                "A man, a plan, a canal, panama",
                "Lleve",
                "Tacotac",
                "asda"
            })
        };

        public override string GetDescription()
        {
            return "Write a function that checks if a given string is a permutation of a palindrome. "
                + "A palindrome is not limited to dictionary words.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
