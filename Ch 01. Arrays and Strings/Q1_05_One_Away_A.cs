using Contracts;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_05_One_Away_A : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new OneAwayA.Solution(new string[][]
            {
                new [] {"pale", "ple"},
                new [] {"pales", "pale"},
                new [] {"pale", "pales"},
                new [] {"pale", "pasle"},
                new [] {"pale", "bale"},
                new [] {"pale", "bake"},
            })
        };

        public override string GetDescription()
        {
            return "There are three kinds of modifying operations on strings: inserting a character, deleting a character, and replacing a character. "
                + "Write a function that checks if two strings are one revision apart.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
