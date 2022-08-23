using Chapter08.PaintFill;
using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_10_Paint_Fill : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Implement the paint fill function. "
                + "Given a plane, a point and a color that needs to fill the entire surrounding space, "
                + "initially painted in a different color.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[] { new Solution(CreateScreen(), 2, 2, Color.Red) };
        }

        private static Color[,] CreateScreen()
        {
            return new Color[,]
            {
                { Color.White, Color.Yellow, Color.Red, Color.Green, Color.White },
                { Color.Black, Color.White, Color.Red, Color.White, Color.Black },
                { Color.Black, Color.White, Color.White, Color.White, Color.Black },
                { Color.Black, Color.White, Color.Red, Color.White, Color.Black },
                { Color.White, Color.Yellow, Color.Red, Color.Green, Color.White },
            };
        }
    }
}
