using System.Data;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(50);
            linkedList.AddNode(40);
            linkedList.AddNode(30);
            linkedList.AddNode(20);
            linkedList.AddNode(10);
            Console.WriteLine(linkedList.PrintList());
            Console.WriteLine("--------------------");
            Console.WriteLine(linkedList.IncludesNode(0));
            Console.WriteLine(linkedList.IncludesNode(30));
        }
    }
    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;
        public LinkedListNode(int i)
        {
            data = i;
            next = null;
        }
    }

    public class LinkedList
    {
        public LinkedListNode head;
        int count;
        public LinkedList()
        {
            head = null;
            count = 0;
        }
        public void AddNode(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
            count++;
        }

        public string PrintList()
        {
            string toString = "";
            LinkedListNode getNodes = head;
            while (getNodes != null)
            {
                toString += $" {{ {getNodes.data} }}-->";
                getNodes = getNodes.next;
            }
            return toString + "null";

        }

        public bool IncludesNode(int data)
        {
            LinkedListNode node = head;
            if (head == null)
            {
                return false;
            }
            else
            {
                while (node != null)
                {
                    if (node.data == data)
                    {
                        return true;
                    }
                    else
                    {
                        node = node.next;
                    }
                }
                return false;
            }
        }

    }
}