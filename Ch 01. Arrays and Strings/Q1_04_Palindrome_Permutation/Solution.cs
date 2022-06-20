using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter01.PalindromePermutation
{
    public class Solution : ISolution
    {
        private string[] lines;

        public Solution(string[] lines)
        {
            this.lines = lines;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            foreach (var line in lines)
            {
                Console.WriteLine($"'{line}': IsPalindromePermutation -> {IsPalindromePermutation(line)}");
            }
        }

        private bool IsPalindromePermutation(string line)
        {
            var countCharsResult = CountChars(line);

            bool hasOneOddValue = false;

            foreach (var keyValue in countCharsResult)
            {
                if (keyValue.Value % 2 != 0)
                {
                    if (hasOneOddValue)
                    {
                        return false;
                    }

                    hasOneOddValue = true;
                }
            }

            return true;
        }

        private Dictionary<char, int> CountChars(string word)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var ch in word.ToLower())
            {
                if (char.IsLetter(ch))
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
            }

            return dictionary;
        }
    }
}
