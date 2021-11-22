using System;
using System.Collections.Generic;

namespace Homework06
{
    public class Node<T> : IEquatable<Node<T>> where T : IComparable<T>
    {
        public T Value { get; set; }
        public List<(Node<T> node, int weight)> Nodes { get; }

        public Node() => Nodes = new();

        public Node(T value) : base()
        {
            Value = value;
        }

        public void AddEdge(Node<T> node, int weight)
        {
            if (node != null)
                Nodes.Add((node, weight));
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
