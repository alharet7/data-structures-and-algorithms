using MaxTree;

namespace BinaryTreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void FindTheMaxIfItIsTheRoot()
        {
            //Arrange
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(25);
            binarySearchTree.Add(3);
            binarySearchTree.Add(7);
            binarySearchTree.Add(2);
            binarySearchTree.Add(4);
            binarySearchTree.Add(6);
            binarySearchTree.Add(8);

            //ACT
            int result = 25;

            //ASSERT

            Assert.Equal(result, binarySearchTree.FindMax());
        }



        [Fact]

        public void FindTheMaxIfItIsNotTheRoot()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(5);
            binarySearchTree.Add(3);
            binarySearchTree.Add(7);
            binarySearchTree.Add(25);
            binarySearchTree.Add(4);
            binarySearchTree.Add(6);
            binarySearchTree.Add(8);

            //ACT
            int result = 25;

            //ASSERT

            Assert.Equal(result, binarySearchTree.FindMax());


        }
    }
}