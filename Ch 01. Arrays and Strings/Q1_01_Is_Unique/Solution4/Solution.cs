using System.Collections.Generic;

namespace Chapter01.IsUnique.Solution4
{
    public class Solution : BaseSolution
    {
        public Solution(IEnumerable<string> strCollection) : base(strCollection) { }

        public override string GetComment()
        {
            return "Compare each character to the rest of the characters in the string.";
        }

        protected override bool IsUniqueChars(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                for (var j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
