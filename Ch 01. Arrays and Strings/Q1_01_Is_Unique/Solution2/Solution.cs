using System.Collections.Generic;

namespace Chapter01.IsUnique.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(IEnumerable<string> strCollection) : base(strCollection) { }

        public override string GetComment()
        {
            return "Memory overhead can be saved by a factor of 8 by using a bit vector. The string contains the lowercase characters a - z.";
        }

        protected override bool IsUniqueChars(string str)
        {
            var checker = 0;

            for (var i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';

                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }

                checker |= (1 << val);
            }

            return true;
        }
    }
}
