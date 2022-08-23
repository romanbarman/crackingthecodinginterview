using Contracts;
using System;

namespace Chapter08.PaintFill
{
    public class Solution : ISolution
    {
        private Color[,] screen;
        private int row;
        private int column;
        private Color fillColor;

        public Solution(Color[,] screen, int row, int column, Color fillColor)
        {
            this.screen = screen;
            this.row = row;
            this.column = column;
            this.fillColor = fillColor;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Origin:");
            ShowScreen();

            PaintFill();

            Console.WriteLine();
            Console.WriteLine("Result:");
            ShowScreen();
        }

        private void PaintFill()
        {
            if (screen[row, column] == fillColor) return;
            PaintFill(row, column, screen[row, column]);
        }

        private void PaintFill(int r, int c, Color color)
        {
            if (r < 0 || r >= screen.GetLength(0) || c < 0 || c >= screen.GetLength(1)) return;

            if (screen[r, c] == color)
            {
                screen[r, c] = fillColor;
                PaintFill(r - 1, c, color);
                PaintFill(r + 1, c, color);
                PaintFill(r, c - 1, color);
                PaintFill(r, c + 1, color);

            }
        }

        private void ShowScreen()
        {
            for (int i = 0; i < screen.GetLength(0); i++)
            {
                for (int j = 0; j < screen.GetLength(1); j++)
                {
                    Console.Write(((int)screen[i, j]).ToString().PadRight(4));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
