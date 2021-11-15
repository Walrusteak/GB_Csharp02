using System;

namespace Task02
{
    public class Node<T> : IEquatable<Node<T>> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node() { }

        public Node(T value)
        {
            Value = value;
        }

        public bool Equals(Node<T> other)
        {
            if (other == null)
                return false;
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj) => Equals(obj as Node<T>);

        public override int GetHashCode() => base.GetHashCode() ^ Value?.GetHashCode() ?? 0;
    }
}
