using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue.Stacks_Queue
{
    public class Queue
    {
        private Node First { get; set; }
        private Node Last { get; set; }
        public int Count { get; set; }

        public Queue()
        {
            First = null;
            Last = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new(data);
            if (First == null)
            {
                First = newNode;
                Last = newNode;
                Count++;
            }
            else
            {
                Last.Next = newNode;
                Last = Last.Next;
                Count++;
            }
        }

        public int Dequeue()
        {
            if (First == null)
            {
                throw new NullReferenceException("The Queue is empty");
            }
            else
            {
                Node dequeueNode = First;
                First = First.Next;
                Count--;
                return dequeueNode.Data;
            }
        }

        public int Peek()
        {
            if (First == null)
            {
                throw new NullReferenceException("The stack is Empty");
            }
            else
            {
                Node peekNode = First;
                return peekNode.Data;

            }
        }

        public bool IsEmpty()
        {
            if (First == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintQueue()
        {
            Node printNode = First;
            Console.Write("First->");
            while (printNode != null)
            {
                Console.Write($"{{{printNode.Data}}} -> ");
                printNode = printNode.Next;
            }
            Console.WriteLine("Null");
        }
    }
}
