using System.Collections.Generic;

namespace Chapter02.RemoveDups.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(Structures.LinkedListNode<int> linkedListNode) : base(linkedListNode) { }

        public override string GetComment()
        {
            return "Used additional memory.";
        }

        protected override void DeleteDublicates(Structures.LinkedListNode<int> top)
        {
            var hashSet = new HashSet<int>();
            hashSet.Add(top.Value);
            var current = top;

            while (current.Next != null)
            {
                if (hashSet.Contains(current.Next.Value))
                {
                    current.SetNext(current.Next.Next);
                }
                else
                {
                    hashSet.Add(current.Next.Value);
                    current = current.Next;
                }
            }
        }
    }
}
