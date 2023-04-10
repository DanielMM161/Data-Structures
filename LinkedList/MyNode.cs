namespace DataStructure.LinkedList;

public class MyNode<T> 
{
    public T value;
    public MyNode<T>? next;
    
    public MyNode(T v, MyNode<T>? n)
    {
        value = v;
        next = n;
    }

    public MyNode()
    {}

}