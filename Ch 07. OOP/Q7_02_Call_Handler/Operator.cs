namespace Chapter07.CallHandler
{
    public class Operator : Employee
    {
        private readonly Manager manager;

        public Operator(string name, CallHandler callHandler, Manager manager): base(name, callHandler)
        {
            this.manager = manager;
        }

        public override bool HandleCall(Call call)
        {
            if (call.Complexity == Complexity.ForOperator)
            {
                SetCall(call);

                return true;
            }

            if (manager.IsFree)
            {
                return manager.HandleCall(call);
            }

            return false;
        }
    }
}
