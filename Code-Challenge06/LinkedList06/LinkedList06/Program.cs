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


            Node node = linkedList.head;
            while (node != null)
            {
                Console.Write($" {{ {node.value} }}==>");
                node = node.Next;
            }
            Console.Write("Null \n\n");
            Console.ReadKey();
        }
    }
    public class Node
    {
        public int value { set; get; }
        public Node Next { set; get; }

        public Node(int data)
        {
            value = data;
        }
    }
    public class LinkedList
    {
        public Node head { set; get; }
        public LinkedList()
        {
            head = null;
        }

        public void Append(int data)
        {
            Node appendNode = new Node(data);

            if (head == null)
            {
                head = appendNode;
            }
            else
            {
                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = appendNode;
            }

        }
        public void InsertBefore(int data, int newdata)
        {
            Node newNode = new Node(newdata);

            if (head == null)
            {
                head = newNode;
                return;
            }

            if (head.value == data)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.value == data)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void InsertAfter(int data, int newdata)
        {
            Node newNode = new Node(newdata);
            Node currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.value == data)
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
            Node current = head;
            Node prev = null;
            if (current != null && current.value == key)
            {
                head = current.Next;
                return;
            }
            while (current != null && current.value != key)
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