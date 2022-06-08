using Contracts;
using Structures;
using System;

namespace Chapter02
{
    public class Q2_06_Palindrome : IQuestion
    {
        public string GetDescription()
        {
            return "Implement a function that checks if the linked list is a palindron.";
        }

        public void Run()
        {
            var words = new []
            {
                LinkedListNode<char>.CreateLinkedList(new[] { 'a', 'p', 'd', 'p', 'a' }),
                LinkedListNode<char>.CreateLinkedList(new[] { 'a', 'p', 'd', 'r', 'a' }),
            };

            foreach (var word in words)
            {
                word.Show();
                Console.Write($": IsPalindrome1 -> {IsPalindrome1(word)}, -> IsPalindrom2 -> {IsPalindrom2(word)}");
                Console.WriteLine();
            }
        }

        private bool IsPalindrom2(LinkedListNode<char> top)
        {
            return (top == null) || (top.Next == null) || IsPalindromeRecurse(ref top, top.Next);
        }

        private bool IsPalindromeRecurse(ref LinkedListNode<char> front, LinkedListNode<char> back)
        {
            var isPalindrome = true;

            if (back.Next != null)
            {
                isPalindrome &= IsPalindromeRecurse(ref front, back.Next);
            }

            isPalindrome &= front.Value == back.Value;
            front = front.Next;

            return isPalindrome;
        }

        private bool IsPalindrome1(LinkedListNode<char> top)
        {
            var currentOriginal = top;
            var currentReverse = Reverse(top);

            while (currentOriginal != null)
            {
                if (currentOriginal.Value != currentReverse.Value)
                {
                    return false;
                }

                currentOriginal = currentOriginal.Next;
                currentReverse = currentReverse.Next;
            }

            return true;
        }

        private LinkedListNode<char> Reverse(LinkedListNode<char> top)
        {
            var newTop = new LinkedListNode<char>(top.Value);

            var current = top.Next;

            while (current != null)
            {
                var node = new LinkedListNode<char>(current.Value);
                node.SetNext(newTop);

                newTop = node;
                current = current.Next;
            }

            return newTop;
        }
    }
}
