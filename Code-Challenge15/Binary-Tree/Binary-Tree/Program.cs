using System;
using System.Collections.Generic;


namespace Binary_Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            binarySearchTree.Add(50);
            binarySearchTree.Add(20);
            binarySearchTree.Add(90);
            binarySearchTree.Add(18);

            List<int> result = binarySearchTree.InOrder(binarySearchTree.root);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //50 20 18 22 40 90 80 100
            Console.ReadKey();
        }
    }
}