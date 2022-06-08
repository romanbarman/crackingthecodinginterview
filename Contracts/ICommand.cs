namespace Contracts
{
    public interface ICommand
    {
        int CommandNumber { get; }
        string Title { get; }
        void Run();
    }
}
