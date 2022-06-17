using System;

namespace Chapter01.CheckPermutation.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(string[][] pairs) : base(pairs) { }

        public override string GetComment()
        {
            return "Sorting lines.";
        }

        protected override bool IsPermutation(string str1, string str2)
        {
            var wordArray1 = str1.ToCharArray();
            var wordArray2 = str2.ToCharArray();

            Array.Sort(wordArray1);
            Array.Sort(wordArray2);

            str1 = new string(wordArray1);
            str2 = new string(wordArray2);

            return str1 == str2;
        }
    }
}
