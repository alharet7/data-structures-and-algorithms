namespace graph_breadth_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            node1.Neighbors.Add(node2);
            node1.Neighbors.Add(node3);
            node2.Neighbors.Add(node4);
            node3.Neighbors.Add(node4);
            node4.Neighbors.Add(node5);

            graph.Nodes.Add(node1);
            graph.Nodes.Add(node2);
            graph.Nodes.Add(node3);
            graph.Nodes.Add(node4);
            graph.Nodes.Add(node5);

            List<Node> result = graph.BreadthFirst(node1);

            Console.WriteLine("Nodes visited in breadth-first order:");
            foreach (Node node in result)
            {
                Console.WriteLine(node.Value);
            }
            Console.ReadKey();
        }
    }
}