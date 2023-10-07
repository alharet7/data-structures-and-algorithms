using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_depth_first
{
    public class Node
    {
        public string Value { get; set; }
        public List<Node> Neighbors { get; set; }

        public Node(string value)
        {
            Value = value;
            Neighbors = new List<Node>();
        }
    }
}
