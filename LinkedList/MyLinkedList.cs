namespace DataStructure.LinkedList;

public class MyLinkedList<T>
{
    public MyNode<T>? head;

    public MyLinkedList()
    {
        head = null;
    }

    public void AddStart(T node)
    {
       MyNode<T> newNode = new MyNode<T>(node, head);
       head = newNode;  
    }

    public void AddEnd(T value)
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
    }

    public void AddAt(int position, T value)
    {        
        if (position <= 0)
        {
            Console.WriteLine("Position should be > 1");
        } else if(position == 1)
        {
           AddStart(value);            
        } else 
        {
            MyNode<T> newNode = new MyNode<T>(value, null);
            var temp = head;
            for (int i = 1; i < position-1 ; i++)
            {
                if(temp != null)
                {
                    temp = temp.next;                    
                }
            }

            if(temp != null) 
            {
                newNode.next = temp.next;
                temp.next = newNode;
            } else {
                AddEnd(value);
            }
        }
    }

    public void DeleteFirst()
    {
        if(head != null)
        {
            var temp = head;
            head = head.next;
            temp = null;
        }
    }

    public void DeleteLast()
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