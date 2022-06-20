using Contracts;
using System;

namespace Chapter01.OneAwayA
{
    public class Solution : ISolution
    {
        private string[][] wordsPair;

        public Solution(string[][] wordsPair)
        {
            this.wordsPair = wordsPair;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            foreach (var pair in wordsPair)
            {
                Console.WriteLine($"{pair[0]}, {pair[1]}: HasOneModification -> {HasOneModification(pair[0], pair[1])}");
            }
        }

        private bool HasOneModification(string original, string newWord)
        {
            if (Math.Abs(original.Length - newWord.Length) > 1)
            {
                return false;
            }

            if (original.Length == newWord.Length)
            {
                return HasOneReplace(original, newWord);
            }

            if (original.Length < newWord.Length)
            {
                return HasOneDelete(newWord, original);
            }

            return HasOneDelete(original, newWord);
        }

        private bool HasOneDelete(string original, string newWord)
        {
            bool hasOneModification = false;

            int j = 0;
            for (var i = 0; i < newWord.Length; i++)
            {
                if (original[j] != newWord[i])
                {
                    if (hasOneModification)
                    {
                        return false;
                    }

                    j++;

                    if (original[j] != newWord[i])
                    {
                        return false;
                    }

                    hasOneModification = true;
                }

                j++;
            }

            return true;
        }

        private bool HasOneReplace(string original, string newWord)
        {
            bool hasOneModification = false;

            for (var i = 0; i < original.Length; i++)
            {
                if (original[i] != newWord[i])
                {
                    if (hasOneModification)
                    {
                        return false;
                    }

                    hasOneModification = true;
                }
            }

            return true;
        }
    }
}
