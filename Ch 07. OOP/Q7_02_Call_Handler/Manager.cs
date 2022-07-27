namespace Chapter07.CallHandler
{
    public class Manager : Employee
    {
        private readonly Director director;

        public Manager(string name, CallHandler callHandler, Director director) : base(name, callHandler)
        {
            this.director = director;
        }

        public override bool HandleCall(Call call)
        {
            if (call.Complexity == Complexity.ForManager || call.Complexity == Complexity.ForOperator)
            {
                SetCall(call);

                return true;
            }

            if (director.IsFree)
            {
                return director.HandleCall(call);
            }

            return false;
        }
    }
}
