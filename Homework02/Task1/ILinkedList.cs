namespace GeekBrainsTests
{
    public interface ILinkedList<T> //прошлую домашку еще не проверили, так что я не знаю, насколько одобряется заигрывание с дженериками
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(T value);  // добавляет новый элемент списка
        void AddNodeAfter(Node<T> node, T value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node<T> node); // удаляет указанный элемент
        Node<T> FindNode(T searchValue); // ищет элемент по его значению
    }
}
