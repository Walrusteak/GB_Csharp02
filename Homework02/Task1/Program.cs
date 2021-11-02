using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> cll = new();
            cll.AddNode(1337);
            Console.WriteLine(cll.GetCount());
            GeekBrainsTests.Node<int> node = cll.FindNode(1337);
            Console.WriteLine(node.Value);
            cll.RemoveNode(node);
            Console.WriteLine(cll.GetCount());
        }
    }
}
