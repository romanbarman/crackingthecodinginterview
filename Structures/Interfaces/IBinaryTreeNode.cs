namespace Structures.Interfaces
{
    public interface IBinaryTreeNode<T>
    {
        T Value { get; }
        IBinaryTreeNode<T> Left { get; }
        IBinaryTreeNode<T> Right { get; }
        void Show();
    }
}
