using linked_list_kth;

namespace linked_list_kth_Test
{
    public class UnitTest1
    {
        [Fact]
        public void KIsGreaterThanTheLengthOfTheLinkedList()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(1);
            linkedList.AddNode(3);
            linkedList.AddNode(5);
            linkedList.AddNode(7);
            linkedList.AddNode(9);

            int result = linkedList.kthFromEnd(7);

            Assert.Equal(-1, result);
        }
        [Fact]
        public void KIsEqualsTheLengthOfTheLinkedList()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(1);
            linkedList.AddNode(3);
            linkedList.AddNode(5);
            linkedList.AddNode(7);
            linkedList.AddNode(9);

            int result = linkedList.kthFromEnd(5);

            Assert.Equal(9, result);
        }

        [Fact]
        public void kIsANegativeNumber()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(1);
            linkedList.AddNode(3);
            linkedList.AddNode(5);
            linkedList.AddNode(7);
            linkedList.AddNode(9);

            int result = linkedList.kthFromEnd(-5);

            Assert.Equal(-1, result);
        }


        [Fact]
        public void WhenListSizeIsOne()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(100);

            // Act
            int result = linkedList.kthFromEnd(1);

            // Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void HappyPathTest()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(1);
            linkedList.AddNode(3);
            linkedList.AddNode(5);
            linkedList.AddNode(7);
            linkedList.AddNode(9);

            int result = linkedList.kthFromEnd(2);

            Assert.Equal(5, result);

        }
    }
}