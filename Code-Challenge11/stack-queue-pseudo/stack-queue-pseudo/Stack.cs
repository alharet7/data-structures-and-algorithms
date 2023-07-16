using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stack_queue_pseudo
{
    public class Stack
    {
        public Node Top { get; set; }
        public int Count { get; set; }
        public Stack()
        {
            Top = null;
        }

        public void Push(int data)
        {
            Node currrentNode = new(data);

            if (Top == null)
            {
                Top = currrentNode;
                Count++;
            }
            else
            {
                currrentNode.Next = Top;
                Top = currrentNode;
                Count++;
            }
        }

        public int Pop()
        {
            if (Top == null)
            {
                throw new NullReferenceException("The Stack is Empty");
            }
            else
            {
                Node removedNode = Top;
                Top = Top.Next;
                Count--;
                return removedNode.Data;
            }
        }


    }
}
