using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = Tree(50);
            BFS(root, 5);
            WriteLine("--------------------");
            DFS(root, 5);
        }

        public static Node<int> Tree(int n)
        {
            if (n == 0)
                return null;
            else
            {
                var nl = n / 2;
                var nr = n - nl - 1;
                Node<int> newNode = new()
                {
                    Value = new Random().Next(10),
                    Left = Tree(nl),
                    Right = Tree(nr)
                };
                return newNode;
            }
        }

        public static Node<int> BFS(Node<int> root, int value)
        {
            Queue<Node<int>> queue = new();
            WriteLine($"Помещаем корень в очередь: {root.Value}");
            queue.Enqueue(root);
            while (queue.Any())
            {
                WriteLine($"Очередь: {String.Join(", ", queue.Select(n => n.Value))}");
                Node<int> node = queue.Dequeue();
                WriteLine($"Забрали элемент: {node.Value}");
                if (node.Value == value)
                {
                    WriteLine($"Искомый элемент: {node.Value}");
                    return node;
                }
                if (node.Left != null)
                {
                    WriteLine($"Помещаем левый элемент в очередь: {node.Left?.Value}");
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    WriteLine($"Помещаем правый элемент в очередь: {node.Right?.Value}");
                    queue.Enqueue(node.Right);
                }
            }
            WriteLine("Элемент не найден");
            return null;
        }

        public static Node<int> DFS(Node<int> root, int value)
        {
            Stack<Node<int>> stack = new();
            WriteLine($"Помещаем корень в стек: {root.Value}");
            stack.Push(root);
            while (stack.Any())
            {
                WriteLine($"Стек: {String.Join(", ", stack.Select(n => n.Value))}");
                Node<int> node = stack.Pop();
                WriteLine($"Забрали элемент: {node.Value}");
                if (node.Value == value)
                {
                    WriteLine($"Искомый элемент: {node.Value}");
                    return node;
                }
                if (node.Left != null)
                {
                    WriteLine($"Помещаем левый элемент в стек: {node.Left?.Value}");
                    stack.Push(node.Left);
                }
                if (node.Right != null)
                {
                    WriteLine($"Помещаем правый элемент в стек: {node.Right?.Value}");
                    stack.Push(node.Right);
                }
            }
            WriteLine("Элемент не найден");
            return null;
        }
    }
}
