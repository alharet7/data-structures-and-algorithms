using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_animal_shelter
{
    public class Node
    {
        public Animals Data { get; set; }
        public Node next { get; set; }

        public Node(Animals animal)
        {
            Data = animal;

        }
    }
}
