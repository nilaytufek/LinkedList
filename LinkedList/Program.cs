using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> myList = new LinkedList<int>();
            Node<int> n1 = new Node<int>(4);
            Node<int> n2 = new Node<int>(2);
            Node<int> n3 = new Node<int>(0);
            Console.WriteLine("adding the node with value: " + n1.value);
            myList.Add(n1);
            Console.WriteLine("my linked list: " + string.Join(" ", myList.GetList()));
            Console.WriteLine("adding the node with value: " + n2.value);
            myList.Add(n2);
            Console.WriteLine("my linked list: " + string.Join(" ", myList.GetList()));
            Console.WriteLine("is " + n2.value + " in the list? : " + myList.Search(n2.value));
            Console.WriteLine("adding the node with value: " + n3.value);
            myList.Add(n3);
            Console.WriteLine("my linked list: " + string.Join(" ", myList.GetList()));

            Console.WriteLine("removing the node with value: " + n2.value);
            myList.Remove(n2);
            Console.WriteLine("my linked list: " + string.Join(" ", myList.GetList()));
            Console.WriteLine("is " + n2.value + " in the list? : " + myList.Search(n2.value));
            Node<int> n4 = new Node<int>(6);
            Console.WriteLine("adding the node with value: " + n4.value);
            myList.Add(n4);
            Console.WriteLine("my linked list: " + string.Join(" ", myList.GetList()));

            
            
        }
    }
}
