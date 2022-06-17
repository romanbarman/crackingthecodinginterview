using System.Collections.Generic;

namespace Chapter01.IsUnique.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(IEnumerable<string> strCollection) : base(strCollection) { }
        public override string GetComment()
        {
            return "Implementation of the algorithm if the string contains ASCII characters.";
        }

        protected override bool IsUniqueChars(string str)
        {
            if (str.Length > 128)
            {
                return false;
            }

            var charSet = new bool[128];

            for (var i = 0; i < str.Length; i++)
            {
                int val = str[i];

                if (charSet[val])
                {
                    return false;
                }

                charSet[val] = true;
            }

            return true;
        }
    }
}
