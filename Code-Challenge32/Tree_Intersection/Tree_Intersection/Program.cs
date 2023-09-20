using System;

namespace Tree_Intersection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two binary search trees
            BinarySearchTree tree1 = new BinarySearchTree();
            BinarySearchTree tree2 = new BinarySearchTree();

            // Add nodes to the trees
            tree1.Add(5);
            tree1.Add(3);
            tree1.Add(8);

            tree2.Add(5);
            tree2.Add(2);
            tree2.Add(7);

            // Find the intersection
            var intersection = TreeIntersection.treeIntersection(tree1, tree2);

            // Display the result
            Console.WriteLine("Intersection:");
            foreach (var item in intersection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
