namespace Chapter07.CallHandler
{
    public class Director : Employee
    {
        public Director(string name, CallHandler callHandler) : base(name, callHandler) { }

        public override bool HandleCall(Call call)
        {
            SetCall(call);

            return true;
        }
    }
}
