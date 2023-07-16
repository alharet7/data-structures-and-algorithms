using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_pseudo
{
    public class Queue_pseudo
    {
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();

        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public int Dequeue()
        {
            if (stack1.Top == null)
            {
                throw new NullReferenceException("The Queue is Empty!!");
            }
            while (stack1.Top != null)
            {
                stack2.Push(stack1.Pop());
            }
            int value = stack2.Pop();

            while (stack2.Top != null)
            {
                stack1.Push(stack2.Pop());
            }

            return value;
        }



    }
}
