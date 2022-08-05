using Contracts;
using System;

namespace Chapter08.TowerOfHanoi
{
    public class Solution : ISolution
    {
        private HanoiTower origin;
        private HanoiTower middle = new HanoiTower("middle");
        private HanoiTower destination = new HanoiTower("destination");

        public Solution(HanoiTower hanoiTower)
        {
            origin = hanoiTower;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Origin: {string.Join(", ", origin)}");
            MoveToDistination(origin.Count, origin, destination, middle);
            Console.WriteLine($"Destination: {string.Join(", ", destination)}");
        }

        private void MoveToDistination(int n, HanoiTower origin, HanoiTower destination, HanoiTower buffer)
        {
            if (n > 0)
            {
                MoveToDistination(n - 1, origin, buffer, destination);
                MoveToTop(origin, destination);
                MoveToDistination(n - 1, buffer, destination, origin);
            }
        }

        private void MoveToTop(HanoiTower origin, HanoiTower destination)
        {
            destination.Push(origin.Pop());
        }
    }
}
