using System;

namespace LinkedLists
{
    class Program
    {
        static void Main()
        {
            var list = new SinglyLinkedLists();
            list.InsertFirst(100);
            list.InsertFirst(50);
            list.InsertFirst(120);
            list.InsertFirst(20);
            list.InsertFirst(1100);
            list.InsertLast(999000);
            list.InsertFirst(1020);
            list.DisplayList();

            list.DeleteFirst();
            list.DisplayList();
        }
    }

    public class SinglyLinkedLists
    {
        private Node first;

        public bool IsEmpty()
        {
            return (first == null);
        }

        public void InsertFirst(int data)
        {
            Node newNode = new Node
            {
                data = data,
                next = first
            };
            first = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("List => First to Last");
            Node current = first;
            while (current != null)
            {
                current.DisplayNode();
                current = current.next;
            }
            Console.WriteLine();
        }

        public void InsertLast(int data)
        {
            Node current = first;
            while(current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }

    public class Node
    {
        public int data;

        public Node next;

        public void DisplayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}
