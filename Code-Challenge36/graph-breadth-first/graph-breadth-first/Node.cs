using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_breadth_first
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Neighbors { get; set; }

        public Node(int value)
        {
            Value = value;
            Neighbors = new List<Node>();
        }
    }
}
