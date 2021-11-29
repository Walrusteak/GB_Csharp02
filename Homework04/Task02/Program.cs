using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new();
            tree.AddItem(8);
            tree.AddItem(3);
            tree.AddItem(10);
            tree.AddItem(1);
            tree.AddItem(6);
            tree.AddItem(14);
            tree.AddItem(4);
            tree.AddItem(7);
            tree.AddItem(13);
            tree.PrintTree();
            Console.ReadKey();
            Console.Clear();

            tree.AddItem(15);
            tree.PrintTree();
            Console.ReadKey();
            Console.Clear();

            tree.RemoveItem(10);
            tree.PrintTree();
            Console.ReadKey();
            Console.Clear();

            Node<int> node = tree.GetNodeByValue(6);
            Console.WriteLine(node.Value);
        }
    }
}
