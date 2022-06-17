using System.Collections.Generic;

namespace Chapter01.CheckPermutation.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(string[][] pairs) : base(pairs) { }

        public override string GetComment()
        {
            return "Verification of counters of identical characters.";
        }

        protected override bool IsPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            var countCharsResult1 = CountChars(str1);
            var countCharsResult2 = CountChars(str2);

            return IsEqualDictionaries(countCharsResult1, countCharsResult2);
        }

        private bool IsEqualDictionaries(Dictionary<char, int> result1, Dictionary<char, int> result2)
        {
            if (result1.Keys.Count != result2.Keys.Count)
            {
                return false;
            }


            foreach (var key in result1.Keys)
            {
                if (!result2.ContainsKey(key))
                {
                    return false;
                }

                if (result1[key] != result2[key])
                {
                    return false;
                }
            }

            return true;
        }

        private Dictionary<char, int> CountChars(string word)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var ch in word)
            {
                if (dictionary.ContainsKey(ch))
                {
                    dictionary[ch]++;
                }
                else
                {
                    dictionary[ch] = 1;
                }
            }

            return dictionary;
        }
    }
}
