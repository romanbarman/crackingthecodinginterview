namespace Chapter08.Robot
{
    class Point
    {
        public int I { get; }
        public int J { get; }

        public Point(int i, int j)
        {
            I = i;
            J = j;
        }

        public override string ToString()
        {
            return $"{I} : {J}";
        }
    }
}
