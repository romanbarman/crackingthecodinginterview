using System.Collections.Generic;

namespace Chapter01.IsUnique.Solution3
{
    public class Solution : BaseSolution
    {
        public Solution(IEnumerable<string> strCollection) : base(strCollection) { }

        public override string GetComment()
        {
            return "Implementation of the algorithm using HashSet.";
        }

        protected override bool IsUniqueChars(string str)
        {
            var hashset = new HashSet<char>();

            foreach (var ch in str)
            {
                if (hashset.Contains(ch))
                {
                    return false;
                }

                hashset.Add(ch);
            }

            return true;
        }
    }
}
