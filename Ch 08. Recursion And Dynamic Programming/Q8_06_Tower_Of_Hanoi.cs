using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_06_Tower_Of_Hanoi : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Towers of Hanoi problem.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[] { new TowerOfHanoi.Solution(Create()) };
        }

        private static TowerOfHanoi.HanoiTower Create()
        {
            var tower = new TowerOfHanoi.HanoiTower("origin");
            tower.Push(5);
            tower.Push(4);
            tower.Push(3);
            tower.Push(2);
            tower.Push(1);

            return tower;
        }
    }
}
