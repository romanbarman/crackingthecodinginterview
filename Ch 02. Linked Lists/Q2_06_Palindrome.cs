using Contracts;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_06_Palindrome : BaseQuestion
    {
        private static readonly Structures.LinkedListNode<char>[] words = new[]
        {
            Structures.LinkedListNode<char>.CreateLinkedList(new[] { 'a', 'p', 'd', 'p', 'a' }),
            Structures.LinkedListNode<char>.CreateLinkedList(new[] { 'a', 'p', 'd', 'r', 'a' }),
        };

        private static readonly ISolution[] solutions = new ISolution[]
        {
            new Palindrome.Solution1.Solution(words),
            new Palindrome.Solution2.Solution(words)
        };

        public override string GetDescription()
        {
            return "Implement a function that checks if the linked list is a palindron.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
