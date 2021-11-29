using System;
namespace Task02
{
    public class Tree<T> : ITree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public void AddItem(T value)
        {
            if (root == null)
                root = new Node<T>(value);
            else
                Insert(root, value);
        }

        public Node<T> GetNodeByValue(T value) => Search(root, value);

        public Node<T> GetRoot() => root;

        public void PrintTree() => InOrderTraversal(root);

        public void RemoveItem(T value) => Delete(root, value);

        private void InOrderTraversal(Node<T> node, int level = 0)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, level + 1);
                Console.WriteLine(new String('\t', level) + node.Value);
                InOrderTraversal(node.Right, level + 1);
            }
        }

        private Node<T> Insert(Node<T> node, T value)
        {
            if (node == null)
                return new Node<T>(value);
            if (value.CompareTo(node.Value) < 0)
                node.Left = Insert(node.Left, value);
            else if (value.CompareTo(node.Value) > 0)
                node.Right = Insert(node.Right, value);
            return node;
        }

        private Node<T> Delete(Node<T> node, T value)
        {
            if (node == null)
                return node;
            if (value.CompareTo(node.Value) < 0)
                node.Left = Delete(node.Left, value);
            else if (value.CompareTo(node.Value) > 0)
                node.Right = Delete(node.Right, value);
            else if (node.Left != null && node.Right != null)
            {
                node.Value = Minimum(node.Right).Value;
                node.Right = Delete(node.Right, node.Value);
            }
            else
            {
                if (node.Left != null)
                    node = node.Left;
                else if (node.Right != null)
                    node = node.Right;
                else node = null;
            }
            return node;
        }

        private Node<T> Minimum (Node<T> node)
        {
            if (node.Left == null)
                return node;
            return Minimum(node.Left);
        }

        private Node<T> Search(Node<T> node, T value)
        {
            if (node == null || node.Value != null && node.Value.Equals(value) || node.Value == null && value == null)
                return node;
            return Search(value.CompareTo(node.Value) < 0 ? node.Left : node.Right, value);
        }
    }
}
