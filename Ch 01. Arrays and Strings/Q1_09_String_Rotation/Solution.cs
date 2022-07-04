using Contracts;
using System;

namespace Chapter01.StringRotation
{
    public class Solution : ISolution
    {
        private readonly string[][] wordPairs;

        public Solution(string[][] wordPairs)
        {
            this.wordPairs = wordPairs;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            foreach (var pair in wordPairs)
            {
                Console.WriteLine($"{pair[0]}, {pair[1]}: IsRotation -> {IsRotation(pair[0], pair[1])}");
            }
        }

        private bool IsRotation(string s1, string s2)
        {
            return IsSubstring(s1 + s1, s2);
        }
        private bool IsSubstring(string s1, string s2)
        {
            return s1.IndexOf(s2) >= 0;
        }
    }
}
