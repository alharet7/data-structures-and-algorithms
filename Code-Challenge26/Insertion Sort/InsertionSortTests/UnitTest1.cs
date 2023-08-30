using Insertion_Sort;

namespace InsertionSortTests
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestInsertionSortalgorithm()
        {
            // Befor sorting
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            // After sorting
            Program.InsertionSort(arr);

            int[] arr2 = { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(arr2, arr);
        }
    }
}