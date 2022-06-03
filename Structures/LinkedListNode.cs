namespace Structures
{
    public class LinkedListNode<T>
    {
        private readonly T value;
        private LinkedListNode<T> next;
        private LinkedListNode<T> prev;

        public LinkedListNode(T value)
        {
            this.value = value;
        }

        public LinkedListNode<T> Next { get { return next; } }
        public LinkedListNode<T> Prev { get { return prev; } }
        public T Value { get { return value; } }

        public void SetNext(LinkedListNode<T> next)
        {
            this.next = next;
        }

        public void SetPrev(LinkedListNode<T> prev)
        {
            this.prev = prev;
        }
    }
}
