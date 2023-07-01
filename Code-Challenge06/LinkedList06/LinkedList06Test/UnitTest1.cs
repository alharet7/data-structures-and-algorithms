using Xunit;

namespace LinkedList06.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void AppendAddNodeToEnd()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();

            // Act
            linkedList.Append(10);

            // Assert
            Assert.Equal(10, linkedList.head.value);
            Assert.Null(linkedList.head.Next);
        }

        [Fact]
        public void AppendAddMultipleNodesToEnd()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();

            // Act
            linkedList.Append(10);
            linkedList.Append(20);
            linkedList.Append(30);

            // Assert
            Assert.Equal(10, linkedList.head.value);
            Assert.Equal(20, linkedList.head.Next.value);
            Assert.Equal(30, linkedList.head.Next.Next.value);
            Assert.Null(linkedList.head.Next.Next.Next);
        }
        [Fact]
        public void InsertBeforeInsertNodeBeforeMiddleNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(10);
            linkedList.Append(30);

            // Act
            linkedList.InsertBefore(30, 20);

            // Assert
            Assert.Equal(10, linkedList.head.value);
            Assert.Equal(20, linkedList.head.Next.value);
            Assert.Equal(30, linkedList.head.Next.Next.value);
            Assert.Null(linkedList.head.Next.Next.Next);
        }
        [Fact]
        public void InsertBeforeInsertNodeBeforeFirstNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(20);
            linkedList.Append(30);

            // Act
            linkedList.InsertBefore(20, 10);

            // Assert
            Assert.Equal(10, linkedList.head.value);
            Assert.Equal(20, linkedList.head.Next.value);
            Assert.Equal(30, linkedList.head.Next.Next.value);

            Assert.Null(linkedList.head.Next.Next.Next);
        }
        [Fact]
        public void InsertAfterInsertNodeAfterMiddleNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(10);
            linkedList.Append(20);
            linkedList.Append(40);

            // Act
            linkedList.InsertAfter(20, 30);

            // Assert
            Assert.Equal(10, linkedList.head.value);
            Assert.Equal(20, linkedList.head.Next.value);
            Assert.Equal(30, linkedList.head.Next.Next.value);
            Assert.Equal(40, linkedList.head.Next.Next.Next.value);
            Assert.Null(linkedList.head.Next.Next.Next.Next);
        }
        [Fact]
        public void InsertAfterInsertNodeAfterLastNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(10);
            linkedList.Append(20);
            linkedList.Append(30);

            // Act
            linkedList.InsertAfter(30, 40);

            // Assert
            Assert.Equal(10, linkedList.head.value);
            Assert.Equal(20, linkedList.head.Next.value);
            Assert.Equal(30, linkedList.head.Next.Next.value);
            Assert.Equal(40, linkedList.head.Next.Next.Next.value);
            Assert.Null(linkedList.head.Next.Next.Next.Next);
        }
    }
}
