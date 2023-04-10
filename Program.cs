using System.Diagnostics;
using DataStructure.DoublyLinkedList;
using DataStructure.LinkedList;
using static System.Console;

internal class Program
{
  private static void Main(string[] args)
  {
    // MyLinkedList<String> myLinkedList = new MyLinkedList<String>();
    // myLinkedList.Push("Jose");
    // myLinkedList.Push("Daniel");    
    // myLinkedList.PushBack("Ayrton");
    // myLinkedList.PushAt(3, "Ira");
    // myLinkedList.PopAt(3);
    // myLinkedList.PopFront();
    // myLinkedList.PopBack();
    // myLinkedList.PrintList();      
    // Console.WriteLine(myLinkedList.SearchEelement("Daniel"));

    MyDoubleLinkedList<String> myDoubleLinkedList = new MyDoubleLinkedList<string>();
    myDoubleLinkedList.Push("Daniel");
    myDoubleLinkedList.Push("Jose");
    myDoubleLinkedList.PushBack("Ira");
    myDoubleLinkedList.PushAt(1,"Palumbo");
    myDoubleLinkedList.Pop();
    myDoubleLinkedList.PrintList();
  }
}