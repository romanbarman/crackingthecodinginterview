using Structures;

namespace Chapter02.Palindrome.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(LinkedListNode<char>[] words) : base(words) { }

        protected override bool IsPalindrome(LinkedListNode<char> word)
        {
            var currentOriginal = word;
            var currentReverse = Reverse(word);

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
