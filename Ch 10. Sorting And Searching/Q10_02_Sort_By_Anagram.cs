using Contracts;
using System.Collections.Generic;

namespace Chapter10
{
    public class Q10_02_Sort_By_Anagram : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new SortByAnagram.Solution(new string[]{ "hello", "money", "lolhe", "rac", "lelho", "world", "car", "dolrw" })
        };

        public override string GetDescription()
        {
            return "Write a method for sorting an array of strings that groups anagrams one after the other.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
