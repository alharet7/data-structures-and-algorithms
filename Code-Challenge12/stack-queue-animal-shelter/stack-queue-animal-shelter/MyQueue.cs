using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_animal_shelter
{
    public class MyQueue
    {
        public Node front;
        public Node back;

        public void Enqueue(Animals animal)
        {
            Node newnode = new Node(animal);
            if (newnode.Data.Species.ToLower() == "cat" || newnode.Data.Species.ToLower() == "dog")
            {
                if (front == null)
                {
                    front = newnode;
                    back = newnode;
                }
                else
                {
                    back.next = newnode;
                    back = newnode;
                }
            }
        }

        public Animals Dequeue(string species)
        {
            if (species.ToLower() == "cat" || species.ToLower() == "dog")
            {
                if (front != null && front.Data.Species.ToLower() == species)
                {
                    Animals a = front.Data;
                    front = front.next;
                    return a;
                }
                else
                {
                    Node f = front;
                    Node temp = f;
                    while (f != null)
                    {
                        if (f.Data.Species.ToLower() == species)
                        {
                            Animals a = f.Data;
                            temp.next = f.next;
                            f = f.next;
                            return a;
                        }
                        temp = f;
                        f = f.next;
                    }
                }
            }
            return null;
        }

        public string Print()
        {
            string result = "";
            Node h = front;
            while (h != null)
            {
                result += $"{{{h.Data.Name} is a {h.Data.Species}}}\n";
                h = h.next;
            }

            return result;
        }
    }
}
