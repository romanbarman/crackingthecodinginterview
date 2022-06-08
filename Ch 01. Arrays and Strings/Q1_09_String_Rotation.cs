using Contracts;
using System;

namespace Chapter01
{
    public class Q1_09_String_Rotation : IQuestion
    {
        public string GetDescription()
        {
            return "Suppose there is an isSubstring method that checks if one word is a substring of another. "
                + "Given two strings s1 and s2, write code that checks whether string s2 was obtained by cyclic shifting s1 using only one call to the isSubstring method.";
        }

        public void Run()
        {
            var wordPairs = new string[][]
            {
                new string[]{"apple", "pleap"},
                new string[]{"waterbottle", "erbottlewat"},
                new string[]{"camera", "macera"}
            };

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
