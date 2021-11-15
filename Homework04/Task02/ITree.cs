using System;

namespace Task02
{
    public interface ITree<T> where T : IComparable<T>
    {
        Node<T> GetRoot();
        void AddItem(T value); // добавить узел
        void RemoveItem(T value); // удалить узел по значению
        Node<T> GetNodeByValue(T value); //получить узел дерева по значению
        void PrintTree(); //вывести дерево в консоль
    }
}
