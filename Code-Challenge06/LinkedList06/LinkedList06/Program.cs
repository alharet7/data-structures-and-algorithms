using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinkedList06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(10);
            linkedList.Append(20);//Deleted Value
            linkedList.Append(30);
            linkedList.Append(40);
            linkedList.Append(50);
            linkedList.InsertBefore(30, 25);
            linkedList.InsertAfter(30, 35);
            linkedList.DeleteNode(20);


            Node node = linkedList.Head;
            while (node != null)
            {
                Console.Write($" {{ {node.Data} }}==>");
                node = node.Next;
            }
            Console.Write("Null \n\n");
            Console.ReadKey();
        }
    }
    public class Node
    {
        public int Data { set; get; }
        public Node Next { set; get; }

        public Node(int data)
        {
            Data = data;
        }
    }
    public class LinkedList
    {
        public Node Head { set; get; }
        public LinkedList()
        {
            Head = null;
        }

        public void Append(int data)
        {
            Node appendNode = new Node(data);

            if (Head == null)
            {
                Head = appendNode;
            }
            else
            {
                Node current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = appendNode;
            }

        }
        public void InsertBefore(int data, int newData)
        {
            Node newNode = new Node(newData);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            if (Head.Data == data)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void InsertAfter(int data, int newData)
        {
            Node newNode = new Node(newData);
            Node currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Data == data)
                {
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                    break;
                }

                currentNode = currentNode.Next;
            }
        }
        public void DeleteNode(int key)
        {
            Node current = Head;
            Node prev = null;
            if (current != null && current.Data == key)
            {
                Head = current.Next;
                return;
            }
            while (current != null && current.Data != key)
            {
                prev = current;
                current = current.Next;
            }
            if (current == null)
            {
                return;
            }
            prev.Next = current.Next;
        }
    }
}