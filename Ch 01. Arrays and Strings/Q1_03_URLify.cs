using Contracts;
using System;

namespace Chapter01
{
    public class Q1_03_URLify : IQuestion
    {
        public string GetDescription()
        {
            return "Write a method that replaces all spaces in a string with '%20' characters. "
                + "You can assume that the length of the string allows you to store additional characters, but in fact the length of the string is known in advance.";
        }

        public void Run()
        {
            var line = "Mr John Smith     ";

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

            foreach(var ch in charArray)
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
