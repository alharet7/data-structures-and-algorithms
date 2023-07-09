using Challange08_linked_list_zip;
namespace linked_list_zipTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestThatTwoLinkedListHasSameLength()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Append(10);
            list1.Append(20);
            list1.Append(30);

            list2.Append(15);
            list2.Append(25);
            list2.Append(35);

            LinkedList zipList = Program.ZipLists(list1, list2);
            Node currentNode = zipList.Head;
            int[] result = new int[6];
            int index = 0;
            while (currentNode != null)
            {
                result[index] = currentNode.Data;
                index++;
                currentNode = currentNode.Next;
            }
            int[] expected = new int[] { 10, 15, 20, 25, 30, 35 };
            Assert.Equal(expected, result);


        }
        [Fact]
        public void TestThatIfTheLinkedListOneShorterThanTheLinkedListTwo()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Append(10);
            list1.Append(5);

            list2.Append(1);
            list2.Append(20);
            list2.Append(25);

            LinkedList zipList = Program.ZipLists(list1, list2);
            Node currentNode = zipList.Head;
            int[] result = new int[5];
            int index = 0;
            while (currentNode != null)
            {
                result[index] = currentNode.Data;
                index++;
                currentNode = currentNode.Next;
            }
            int[] expected = new int[] { 10, 1, 5, 20, 25 };
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestTahtIfTheLinkedListTwoShorterThanTheLinkedListOne()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Append(5);
            list1.Append(10);
            list1.Append(30);

            list2.Append(15);
            list2.Append(20);

            LinkedList zipList = Program.ZipLists(list1, list2);
            Node currentNode = zipList.Head;
            string result = "";
            while (currentNode != null)
            {
                result += $"{{ {currentNode.Data} }} -> ";
                currentNode = currentNode.Next;
            }
            result += "Null";

            int[] expected = new int[] { 5, 15, 10, 20, 30 };
            Assert.Equal("{ 5 } -> { 15 } -> { 10 } -> { 20 } -> { 30 } -> Null", result);
        }
    }
}