namespace graph_depth_first
{
    internal class Program
    {
        public static void Main()
        {

            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node F = new Node("F");
            Node G = new Node("G");
            Node H = new Node("H");


            A.Neighbors.Add(B);
            A.Neighbors.Add(C);
            B.Neighbors.Add(D);
            B.Neighbors.Add(E);
            C.Neighbors.Add(F);
            D.Neighbors.Add(G);
            E.Neighbors.Add(H);


            Graph graph = new Graph();
            graph.Nodes.Add(A);
            graph.Nodes.Add(B);
            graph.Nodes.Add(C);
            graph.Nodes.Add(D);
            graph.Nodes.Add(E);
            graph.Nodes.Add(F);
            graph.Nodes.Add(G);
            graph.Nodes.Add(H);


            List<Node> result = graph.DepthFirst(A);


            foreach (Node node in result)
            {
                Console.Write(node.Value + " ");
            }
            Console.ReadKey();
        }
    }
}