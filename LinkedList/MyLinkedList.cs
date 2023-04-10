namespace DataStructure.LinkedList;

public class MyLinkedList<T>
{
    private int _count { get; set; }
    public MyNode<T>? head;

    public MyLinkedList()
    {
        head = null;
    }

    public void Push(T node)
    {
       MyNode<T> newNode = new MyNode<T>(node, head);
       head = newNode;  
       _count++;
    }

    public void PushBack(T value)
    {
        MyNode<T> newNode = new MyNode<T>(value, null);
        if (head == null)
        {
            head = newNode;
        } else 
        {            
            var temp = head;            
            while(temp.next != null)
            {
                temp = temp.next;                
            }
            temp.next = newNode;
        }
        _count++;
    }

    public void PushAt(int position, T value)
    {        
        if (position < 0)
        {
            Console.WriteLine("Position should be > 1");
        } else if(position == 0)
        {
           Push(value);            
        } else 
        {
            MyNode<T> newNode = new MyNode<T>(value, null);
            var temp = head;
            for (int i = 1; i < position; i++)
                if(temp != null)
                    temp = temp.next;                    

            if(temp != null) 
            {
                newNode.next = temp.next;
                temp.next = newNode;
            } else {
                PushBack(value);               
            }
        }
        _count++;
    }

    public void PopFront()
    {
        if(head != null)
        {
            var temp = head;
            head = head.next;
            temp = null;
        }
        _count--;
    }

    public void PopBack()
    {
        if (head != null)
        {
            if (head.next == null)
            {
                head = null;
            } else {
                var temp = head;
                while(temp.next.next != null)               
                    temp = temp.next;

                var lastNode = temp.next;
                temp.next = null;
                lastNode = null;               
            }
        }
        _count--;
    }

    public void PopAt(int position)
    {
        if (position < 0)
        {
            throw new ArgumentException("Position must to be grather than 0");
        }

        if (position == 0 && head != null)
        {
            var temp = head;
            temp = head.next;
            head = null;
        } else 
        {            
            var temp = head;
            for (int i = 1; i < position; i++)             
                if(temp != null)
                    temp = temp.next;                                            

            if (temp != null && temp.next != null)
            {
                var nodeDelete = temp.next;
                temp.next = temp.next.next;
                nodeDelete = null;
            } else 
            {
                Console.WriteLine("The node is already null");
            }
        }
        _count--;
    }

    public void DeleteAllNodes()
    {
        MyNode<T> newNode = new MyNode<T>();
        var temp = head;
        while(head != null)
        {
            temp = head;
            head = head.next;
            temp = null;
        }
        _count = 0;
    }

    public T? SearchEelement(T elementSearch)
    {
        var temp = head;
        if (temp == null)
        {
            return default(T);
        }

        MyNode<T> matchEelement = new MyNode<T>();
        while(temp != null)
        {
            if(EqualityComparer<T>.Default.Equals(temp.value, elementSearch))
            {
                matchEelement = temp;
                break;
            }

            temp = temp.next;
        }
        return matchEelement.value;
    }

    public int Length()
    {
        return _count;
    }

    public void PrintList() 
    {
        var temp = head;

        if (temp == null)
        {
            Console.WriteLine("Empty Linked List");
        }

        while(temp != null)
        {
            Console.WriteLine($"{temp.value}");
            temp = temp.next;
        }
    }
}