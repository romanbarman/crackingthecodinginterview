namespace Structures.Interfaces
{
    public interface IBinaryTreeNode<T>
    {
        T Value { get; }
        IBinaryTreeNode<T> Left { get; }
        IBinaryTreeNode<T> Right { get; }
        IBinaryTreeNode<T> Parent { get; }
        void SetLeft(IBinaryTreeNode<T> left);
        void SetRight(IBinaryTreeNode<T> right);
        void SetParent(IBinaryTreeNode<T> parent);
        void Show();
    }
}
