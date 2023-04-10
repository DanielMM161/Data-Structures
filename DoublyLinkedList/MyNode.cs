namespace DataStructure.DoublyLinkedList;

public class MyNode<T>
{
    public T Value;
    public MyNode<T>? Next;
    public MyNode<T>? Prev;

    public MyNode()
    {}

    public MyNode(T value, MyNode<T>? next, MyNode<T>? prev)
    {
        Value = value;
        Next = next;
        Prev = prev;
    }
    
}