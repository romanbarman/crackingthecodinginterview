using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_02_Check_Permutation : IQuestion
    {
        public string GetDescription()
        {
            return "For two strings, write a method to determine if one string is a permutation of the other.";
        }

        public void Run()
        {
            var pairs = new string [][]
            {
                new [] { "god", "dog"},
                new [] { "description", "scriptiondi"},
                new [] { "permutation", "mutationper"},
            };

            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair[0]} {pair[1]}: IsPermutation1 -> {IsPermutation1(pair[0], pair[1])}, IsPermutation2 -> {IsPermutation2(pair[0], pair[1])}");
            }
        }

        private bool IsPermutation1(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            var countCharsResult1 = CountChars(word1);
            var countCharsResult2 = CountChars(word2);

            return IsEqualDictionaries(countCharsResult1, countCharsResult2);
        }

        private bool IsPermutation2(string word1, string word2)
        {
            var wordArray1 = word1.ToCharArray();
            var wordArray2 = word2.ToCharArray();

            Array.Sort(wordArray1);
            Array.Sort(wordArray2);

            word1 = new string(wordArray1);
            word2 = new string(wordArray2);

            return word1 == word2;
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
