namespace DataStructure.DoublyLinkedList;

public class MyDoubleLinkedList<T>
{
    public MyNode<T>? head;
    private int _count {get; set;}

    public MyDoubleLinkedList() => head = null;

    public void Push(T value)
    {
        MyNode<T> newNode = new MyNode<T>(value, null, null);
        if (!isInsertedHead(newNode))
        {
            head.Prev = newNode;
            newNode.Next = head;
            head = newNode;            
        }
    }

    public void PushBack(T value)
    {
        MyNode<T> newNode = new MyNode<T>(value, null, null);
        if (!isInsertedHead(newNode))
        {
            var temp = head;
            while(temp.Next != null)
                temp = temp.Next;
            
            temp.Next = newNode;
            newNode.Prev = temp;
        }
    }

    public void PushAt(int position, T value)
    {
        if(position < 0)
        {
            throw new ArgumentException("Position must to be > 0");
        }

        if(position == 0)
        {
            Push(value);
        } 

        if(position > 0)
        {
            var temp = head;
            for(int i = 1; i < position; i++)
               if(temp != null)
                    temp = temp.Next;

            MyNode<T> newNode = new MyNode<T>(value, null, null);
            newNode.Next = temp.Next;
            newNode.Prev = temp;
            temp.Next = newNode;
            if (newNode.Next != null)
                newNode.Next.Prev = newNode;
        } 
    }

    public void Pop()
    {
        if (head != null )
        {
            var temp = head;
            head = head.Next;
            temp = null;
            if (head != null) head.Prev = null;
        }
    }

    public void PopBack()
    {
        if (head != null)
        {   
            if(head.Next == null)
            {
                head = null;
            } else
            {
                var temp = head;
                while(temp.Next.Next != null)
                    temp = temp.Next;                
                temp.Next = null;                
            }
        }
    }

    public void PrintList()
    {
        if (head != null)
        {
            var temp = head;
            while(temp != null)
            {
                Console.WriteLine($"Value: {temp.Value}");
                temp = temp.Next;
            }
        } else
        {
            Console.WriteLine("The List Is Empty");
        }
    }

    private Boolean isInsertedHead(MyNode<T> node)
    {
        if (head == null)
        {
            head = node;
            return true;
        }
        return false;
    }
}