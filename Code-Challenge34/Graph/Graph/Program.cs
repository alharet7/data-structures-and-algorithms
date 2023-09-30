using CodeChallenge.CodeChallenge.Graphs;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graphs graph = new Graphs();

            // Adding vertices
            GraphNode nodeA = graph.AddVertex("A");
            GraphNode nodeB = graph.AddVertex("B");
            GraphNode nodeC = graph.AddVertex("C");

            // Adding edges
            graph.AddEdge(nodeA, nodeB, 5);
            graph.AddEdge(nodeA, nodeC, 2);

            // Getting vertices
            var vertices = graph.GetVertices();
            Console.WriteLine("Vertices:");
            foreach (var vertex in vertices)
            {
                Console.WriteLine(vertex.Value);
            }

            // Getting neighbors
            var neighborsOfA = graph.GetNeighbors(nodeA);
            Console.WriteLine("\nNeighbors of A:");
            foreach (var neighbor in neighborsOfA)
            {
                Console.WriteLine(neighbor.Value);
            }

            // Getting size
            var size = graph.Size();
            Console.WriteLine($"\nSize of the graph: {size}");

            Console.ReadKey();
        }
    }
}