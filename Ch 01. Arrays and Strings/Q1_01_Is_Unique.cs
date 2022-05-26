using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_01_Is_Unique : IQuestion
    {
        public string GetDescription()
        {
            return "Implement an algorithm that determines whether all characters in a string occur only once. "
                + "And if it is forbidden to use additional data structures?";
        }

        public void Run()
        {
            var words = new[] { "hello", "world", "car", "google" };

            foreach (var word in words)
            {
                Console.WriteLine($"Word '{word}': IsUniqueChars1 -> {IsUniqueChars1(word)}, IsUniqueChars2 -> {IsUniqueChars2(word)}");
            }
        }

        private bool IsUniqueChars1(string word)
        {
            var hashset = new HashSet<char>();

            foreach (var ch in  word)
            {
                if (hashset.Contains(ch))
                {
                    return false;
                }

                hashset.Add(ch);
            }

            return true;
        }

        private bool IsUniqueChars2(string word)
        {
            for (var i = 0; i < word.Length; i++)
            {
                for (var j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
