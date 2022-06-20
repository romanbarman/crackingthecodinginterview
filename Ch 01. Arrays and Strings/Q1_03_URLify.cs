using Contracts;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_03_URLify : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new URLify.Solution("Mr John Smith     ")
        };

        public override string GetDescription()
        {
            return "Write a method that replaces all spaces in a string with '%20' characters. "
                + "You can assume that the length of the string allows you to store additional characters, but in fact the length of the string is known in advance.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
