using Contracts;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_09_String_Rotation : BaseQuestion
    {
        private static string[][] wordPairs = new string[][]
        {
            new string[]{"apple", "pleap"},
            new string[]{"waterbottle", "erbottlewat"},
            new string[]{"camera", "macera"}
        };

        private static readonly ISolution[] solutions = new ISolution[]
        {
            new StringRotation.Solution(wordPairs)
        };

        public override string GetDescription()
        {
            return "Suppose there is an isSubstring method that checks if one word is a substring of another. "
                + "Given two strings s1 and s2, write code that checks whether string s2 was obtained by cyclic shifting s1 using only one call to the isSubstring method.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
