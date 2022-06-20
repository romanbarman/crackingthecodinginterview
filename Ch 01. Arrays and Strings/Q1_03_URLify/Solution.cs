using Contracts;
using System;

namespace Chapter01.URLify
{
    public class Solution : ISolution
    {
        private string line;

        public Solution(string line)
        {
            this.line = line;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"'{line}': ReplaceSpaces -> {ReplaceSpaces(line)}");
        }

        private string ReplaceSpaces(string line)
        {
            var inputArray = line.ToCharArray();
            var spacesCount = CountSpaces(inputArray);

            var outputArray = new char[inputArray.Length + spacesCount * 2];

            FillOtputArray(inputArray, outputArray);

            return new string(outputArray);
        }

        private void FillOtputArray(char[] inputArray, char[] outputArray)
        {
            var i = 0;
            var charaectersInstedSpace = new[] { '%', '2', '0' };

            foreach (var ch in inputArray)
            {
                if (ch == ' ')
                {
                    SetCharacters(outputArray, charaectersInstedSpace, ref i);
                }
                else
                {
                    SetCharacters(outputArray, new[] { ch }, ref i);
                }
            }
        }

        private void SetCharacters(char[] outputArray, char[] characters, ref int index)
        {
            foreach (char ch in characters)
            {
                outputArray[index] = ch;
                index++;
            }
        }

        private int CountSpaces(char[] charArray)
        {
            var result = 0;

            foreach (var ch in charArray)
            {
                if (ch == ' ')
                {
                    result++;
                }
            }

            return result;
        }
    }
}
