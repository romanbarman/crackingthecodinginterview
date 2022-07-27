namespace Chapter07.CallHandler
{
    public class Call
    {
        public Complexity Complexity { get; }
        public int Number { get; }
        public bool IsHandling { get; set; }

        public Call(Complexity complexity, int number)
        {
            Complexity = complexity;
            Number = number;
            IsHandling = false;
        }
    }
}
