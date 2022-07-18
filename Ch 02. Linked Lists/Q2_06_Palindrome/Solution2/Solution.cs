using Structures;

namespace Chapter02.Palindrome.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(LinkedListNode<char>[] words) : base(words) { }

        protected override bool IsPalindrome(LinkedListNode<char> word)
        {
            return (word == null) || (word.Next == null) || IsPalindromeRecurse(ref word, word.Next);
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
    }
}
