using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_04_Palindrome_Permutation : IQuestion
    {
        public string GetDescription()
        {
            return "Write a function that checks if a given string is a permutation of a palindrome. "
                + "A palindrome is not limited to dictionary words.";
        }


        public void Run()
        {
            var lines = new []
            {
                "Rats live on no evil star",
                "A man, a plan, a canal, panama",
                "Lleve",
                "Tacotac",
                "asda"
            };

            foreach (var line in lines)
            {
                Console.WriteLine($"{line}: IsPalindromePermutation -> {IsPalindromePermutation(line)}");
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
