using Contracts;
using System;
using System.Text;

namespace Chapter01
{
    public class Q1_06_String_Compression : IQuestion
    {
        public string GetDescription()
        {
            return "Implement a method to perform basic string compression using a repeated character count. "
                + "If the compressed string does not become shorter than the original string, then the method returns the original string.";
        }

        public void Run()
        {
            var words = new[] { "aabcccccaaad", "abcd", "aabbc" };

            foreach (var word in words)
            {
                Console.WriteLine($"{word}: Compression -> {Compression(word)}");
            }
        }

        private string Compression(string original)
        {
            var sb = new StringBuilder();

            int count = 1;
            sb.Append(original[0]);

            for (var i = 1; i < original.Length; i++)
            {
                if (original[i - 1] == original[i])
                {
                    count++;
                }
                else
                {
                    sb.Append(count.ToString());
                    sb.Append(original[i]);
                    count = 1;
                }
            }

            sb.Append(count);

            return sb.Length < original.Length ? sb.ToString() : original;
        }
    }
}
