using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Homework06
{
    class Program
    {
        private static Random random;

        static void Main(string[] args)
        {
            random = new();
            Node<int> root = Graph(50);
            BFS(root, 5);
            WriteLine("--------------------");
            DFS(root, 5);
        }

        public static Node<int> Graph(int n)
        {
            if (n == 0)
                return null;
            else
            {
                Node<int> newNode = new() { Value = new Random().Next(10) };
                if (--n > 0)
                {
                    int cnt = random.Next(1, Math.Min(5, n));
                    for (int i = 0; i < cnt; i++)
                    {
                        int nextCnt = n - i * n / cnt;
                        newNode.AddEdge(Graph(nextCnt), random.Next(100));
                    }
                }
                return newNode;
            }
        }

        public static Node<int> BFS(Node<int> root, int value)
        {
            List<Node<int>> passed = new();
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
                passed.Add(node);
                WriteLine("Помещаем связанные узлы в очередь");
                foreach (var edge in node.Nodes)
                {
                    if (!passed.Contains(edge.node))
                        queue.Enqueue(edge.node);
                }
            }
            WriteLine("Элемент не найден");
            return null;
        }

        public static Node<int> DFS(Node<int> root, int value)
        {
            List<Node<int>> passed = new();
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
                passed.Add(node);
                WriteLine("Помещаем связанные узлы в стек");
                foreach (var edge in node.Nodes)
                {
                    if (!passed.Contains(edge.node))
                        stack.Push(edge.node);
                }
            }
            WriteLine("Элемент не найден");
            return null;
        }
    }
}
