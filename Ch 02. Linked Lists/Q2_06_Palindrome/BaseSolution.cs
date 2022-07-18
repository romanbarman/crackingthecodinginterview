using Contracts;
using Structures;
using System;

namespace Chapter02.Palindrome
{
    public abstract class BaseSolution : ISolution
    {
        private readonly LinkedListNode<char>[] words;

        protected BaseSolution(LinkedListNode<char>[] words)
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
                word.Show();
                Console.Write($": IsPalindrome -> {IsPalindrome(word)}");
                Console.WriteLine();
            }
        }

        protected abstract bool IsPalindrome(LinkedListNode<char> word);
    }
}
