using System.Diagnostics;
using DataStructure.LinkedList;
using static System.Console;

internal class Program
{
  private static void Main(string[] args)
  {
    MyLinkedList<String> myLinkedList = new MyLinkedList<String>();

    myLinkedList.AddStart("Jose");
    myLinkedList.AddStart("Daniel");    
    myLinkedList.AddEnd("Ayrton");
    myLinkedList.AddAt(1, "Ira");
    myLinkedList.DeleteFirst();
    myLinkedList.DeleteLast();
    myLinkedList.PrintList();  
  }
}