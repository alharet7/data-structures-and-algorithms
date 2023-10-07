using graph_breadth_first;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBreadthFirst()
        {
            // Arrange
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

            // Act
            List<Node> result = graph.BreadthFirst(node1);

            // Assert
            Assert.Equal(5, result.Count);
            Assert.Equal(node1, result[0]);
            Assert.Equal(node2, result[1]);
            Assert.Equal(node3, result[2]);
            Assert.Equal(node4, result[3]);
            Assert.Equal(node5, result[4]);
        }

        [Fact]
        public void TestBreadthFirstSingleNode()
        {
            // Arrange
            Graph graph = new Graph();
            Node node1 = new Node(1);
            graph.Nodes.Add(node1);

            // Act
            List<Node> result = graph.BreadthFirst(node1);

            // Assert
            Assert.Single(result);
            Assert.Equal(node1, result[0]);
        }

        [Fact]
        public void TestBreadthFirstDisconnectedGraph()
        {
            // Arrange
            Graph graph = new Graph();
            Node node1 = new Node(1);
            Node node2 = new Node(2);

            graph.Nodes.Add(node1);
            graph.Nodes.Add(node2);

            // Act
            List<Node> result = graph.BreadthFirst(node1);

            // Assert
            Assert.Equal(1, result.Count);
            Assert.Equal(node1, result[0]);
        }
    }
}