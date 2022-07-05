using Structures;

namespace Chapter02.RemoveDups.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(LinkedListNode<int> linkedListNode) : base(linkedListNode) { }

        public override string GetComment()
        {
            return "Without additional memory.";
        }

        protected override void DeleteDublicates(LinkedListNode<int> top)
        {
            var first = top;
            var second = top;

            while (first != null)
            {
                while (second.Next != null)
                {
                    if (first.Value == second.Next.Value)
                    {
                        second.SetNext(second.Next.Next);
                    }
                    else
                    {
                        second = second.Next;
                    }
                }

                first = first.Next;
                second = first;
            }
        }
    }
}
