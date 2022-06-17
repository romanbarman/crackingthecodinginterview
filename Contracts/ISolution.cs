namespace Contracts
{
    public interface ISolution
    {
        bool HasComment { get; }
        string GetComment();
        void Run();
    }
}
