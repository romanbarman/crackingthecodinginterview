using Contracts;
using System;
using System.Text;

namespace Chapter01.StringCompression
{
    public class Solution : ISolution
    {
        private string[] words;

        public Solution(string[] words)
        {
            this.words = words;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
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
