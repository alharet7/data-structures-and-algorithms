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
            Console.WriteLine(linkedList.kthFromEnd(3));



            Console.WriteLine($"----------------------- \n");
            Node node = linkedList.head;
            while (node != null)
            {

                Console.Write($" {{ {node.data} }}==>");
                node = node.next;
            }
            Console.Write("{Null} \n \n");
            Console.ReadLine();
        }
    }
    public class Node
    {
        public int data { get; set; }
        public Node next { get; set; }
        public Node(int k)
        {
            data = k;
            next = null;
        }
    }
    public class LinkedList
    {

        public Node head { get; set; }

        public void AddNode(int data)
        {
            Node node = new Node(data);
            node.data = data;
            node.next = head;
            head = node;
        }
        public int kthFromEnd(int k)
        {
            try
            {
                if (k < 0)
                {
                    throw new Exception("Enter a positive number,please!");
                }
                int counter = 0;
                Node node = head;
                while (node != null)
                {
                    node = node.next;
                    counter++;
                }
                if (k > counter)
                {
                    throw new Exception("your number is greater than the list!");
                }
                if (counter == k)
                {
                    return head.data;
                }
                int nodeNum = counter - k;
                node = head;
                while (nodeNum > 1)
                {
                    node = node.next;
                    nodeNum--;
                }
                return node.data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}