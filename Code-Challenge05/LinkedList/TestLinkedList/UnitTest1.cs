using LinkedLists;
namespace TestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void IsItEmptyLinkedList()
        {
            // Arrange
            LinkedList List = new LinkedList();
            // Assert
            Assert.Null(List.head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();

            // Act
            linkedList.AddNode(10);

            // Assert
            Assert.NotNull(linkedList.head);
            Assert.Equal(10, linkedList.head.data);
            Assert.Null(linkedList.head.next);

        }

        [Fact]
        public void HeadPointToFirstNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();

            // Act
            linkedList.AddNode(10);
            linkedList.AddNode(30);

            // Assert
            Assert.Equal(30, linkedList.head.data);
        }

        [Fact]
        public void InsertMultiNodes()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();

            // Act
            linkedList.AddNode(10);
            linkedList.AddNode(10);
            linkedList.AddNode(10);
            linkedList.AddNode(30);

            // Assert
            Assert.Equal(30, linkedList.head.data);
            Assert.NotNull(linkedList.head.next);
            Assert.NotNull(linkedList.head.next.next);

        }

        [Fact]
        public void ReturnTrueIfExist()
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddNode(10);
            linkedList.AddNode(20);
            linkedList.AddNode(30);
            linkedList.AddNode(40);

            bool result = linkedList.IncludesNode(10);

            Assert.True(result);
        }

        [Fact]
        public void ReturnTrueIfNotExist()
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddNode(5);
            linkedList.AddNode(15);
            linkedList.AddNode(25);
            linkedList.AddNode(35);

            bool result = linkedList.IncludesNode(100);

            Assert.False(result);
        }

        [Fact]
        public void ReturnCollection()
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddNode(50);
            linkedList.AddNode(35);
            linkedList.AddNode(25);
            linkedList.AddNode(15);
            linkedList.AddNode(5);

            string result = " { 5 }--> { 15 }--> { 25 }--> { 35 }--> { 50 }-->null";

            Assert.Equal(result, linkedList.PrintList());
        }
    }
}