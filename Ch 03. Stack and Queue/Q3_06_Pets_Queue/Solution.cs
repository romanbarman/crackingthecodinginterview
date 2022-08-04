using Contracts;
using System;

namespace Chapter03.PetsQueue
{
    public class Solution : ISolution
    {
        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            var queue = new PetsQueue();
            queue.Enqueue(new Dog());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Cat());
            queue.Enqueue(new Dog());
            queue.Enqueue(new Cat());
            queue.Show();

            Console.WriteLine();
            Console.Write("After operations DequeueAny -> ");
            queue.DequeueAny();
            queue.Show();

            Console.WriteLine();
            Console.Write("After operations DequeueCat -> ");
            queue.DequeueCat();
            queue.Show();

            Console.WriteLine();
            Console.Write("After operations DequeueCat -> ");
            queue.DequeueCat();
            queue.Show();

            Console.WriteLine();
            Console.Write("After operations DequeueDog -> ");
            queue.DequeueDog();
            queue.Show();

            Console.WriteLine();
            Console.Write("After operations DequeueAny -> ");
            queue.DequeueAny();
            queue.Show();
        }
    }
}
