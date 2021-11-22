using System;
using GeekBrainsTests;
namespace Task1
{
    public class CustomLinkedList<T> : ILinkedList<T>
    {
        private Node<T> FirstNode;

        public void AddNode(T value)
        {
            if (FirstNode == null)
                FirstNode = new Node<T> { Value = value };
            else
            {
                Node<T> node = FirstNode;
                while (node.NextNode != null)
                    node = node.NextNode;
                node.NextNode = new Node<T> { Value = value, PrevNode = node };
            }
        }

        public void AddNodeAfter(Node<T> node, T value)
        {
            Node<T> wantedNode = FindNode(value);
            if (wantedNode == null)
                throw new ArgumentOutOfRangeException("Value not found in the list");
            Node<T> wantedNodeNext = wantedNode.NextNode;
            wantedNode.NextNode = new Node<T> { Value = value, PrevNode = wantedNode, NextNode = wantedNodeNext };
            if (wantedNodeNext != null)
                wantedNodeNext.PrevNode = wantedNode.NextNode;
        }

        public Node<T> FindNode(T searchValue)
        {
            Node<T> wantedNode = FirstNode;
            while (wantedNode != null && !(wantedNode.Value == null && searchValue == null) && (!wantedNode.Value?.Equals(searchValue) ?? true))
                wantedNode = wantedNode.NextNode;
            return wantedNode;
        }

        public int GetCount()
        {
            int n = 0;
            Node<T> node = FirstNode;
            while (node != null)
            {
                n++;
                node = node.NextNode;
            }
            return n;
        }

        public void RemoveNode(int index)
        {
            int n = 0;
            Node<T> node = FirstNode;
            while (node != null && n != index)
            {
                n++;
                node = node.NextNode;
            }
            if (node == null)
                throw new IndexOutOfRangeException($"Node with index = {index} does not exist");
            RemoveNode(node);
        }

        public void RemoveNode(Node<T> node)
        {
            if (node == null)
                throw new ArgumentNullException();
            if (node == FirstNode)
                FirstNode = node.NextNode;
            else
                node.PrevNode.NextNode = node.NextNode;
            if (node.NextNode != null)
                node.NextNode.PrevNode = node.PrevNode;
        }
    }
}
