using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_depth_first
{
    public class Graph
    {
        public List<Node> Nodes { get; set; }

        public Graph()
        {
            Nodes = new List<Node>();
        }

        public List<Node> DepthFirst(Node start)
        {
            List<Node> result = new List<Node>();
            HashSet<Node> visited = new HashSet<Node>();

            Stack<Node> stack = new Stack<Node>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                Node tempNode = stack.Pop();

                if (!visited.Contains(tempNode))
                {
                    result.Add(tempNode);
                    visited.Add(tempNode);

                    foreach (var neighbor in tempNode.Neighbors)
                    {
                        stack.Push(neighbor);
                    }
                }
            }

            return result;
        }

    }
}
