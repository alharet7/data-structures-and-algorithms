using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_breadth_first
{
    public class Graph
    {
        public List<Node> Nodes { get; set; }

        public Graph()
        {
            Nodes = new List<Node>();
        }

        public List<Node> BreadthFirst(Node start)
        {
            List<Node> visited = new List<Node>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                if (!visited.Contains(current))
                {
                    visited.Add(current);
                    foreach (Node neighbor in current.Neighbors)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return visited;
        }
    }
}
