using System.Security.Cryptography.X509Certificates;

namespace linked_list_kth
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(50);
            linkedList.AddNode(40);
            linkedList.AddNode(30);
            linkedList.AddNode(20);
            linkedList.AddNode(10);
            Console.WriteLine(linkedList.kthFromEnd(0));



            Console.WriteLine($"----------------------- \n");
            Node node = linkedList.Head;
            while (node != null)
            {

                Console.Write($" {{ {node.Data} }}==>");
                node = node.Next;
            }
            Console.Write("{Null} \n \n");
            Console.ReadLine();
        }
    }
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int k)
        {
            Data = k;
            Next = null;
        }
    }
    public class LinkedList
    {

        public Node Head { get; set; }

        public void AddNode(int data)
        {
            Node node = new Node(data);
            node.Data = data;
            node.Next = Head;
            Head = node;
        }
        public int kthFromEnd(int k)
        {
            if (k < 0)
            {
                Console.WriteLine("Enter a positive number, please!");
                return -1; // or throw an ArgumentException
            }

            int counter = 0;
            Node node = Head;
            while (node != null)
            {
                node = node.Next;
                counter++;
            }

            if (k >= counter)
            {
                Console.WriteLine("Your number is greater than the list!");
                return -1; // or throw an ArgumentException
            }

            int nodeNum = counter - k;
            node = Head;
            while (nodeNum > 1)
            {
                node = node.Next;
                nodeNum--;
            }

            return node.Data;
        }


    }
}