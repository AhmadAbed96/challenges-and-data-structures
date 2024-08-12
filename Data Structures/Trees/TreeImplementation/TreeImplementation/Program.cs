using System.ComponentModel;

namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Binary_Search_Tree binarySearchTree = new Binary_Search_Tree(3);
            binarySearchTree.Add(8);
            binarySearchTree.Add(2);
            binarySearchTree.Add(1);
            binarySearchTree.Add(5);
            binarySearchTree.Add(7);
            Console.WriteLine("Pre-Order-Traversal");
            binarySearchTree.Pre_Order(binarySearchTree.Root);

            Console.WriteLine();
            Console.WriteLine("In-Order-Traversal");

            binarySearchTree.In_Order(binarySearchTree.Root);
            Console.WriteLine();
            Console.WriteLine("Post-Order-Traversal");
            Console.WriteLine("Remove 8");

            binarySearchTree.Remove(8);

            binarySearchTree.Post_Order(binarySearchTree.Root);

            bool contains = binarySearchTree.Contain(5); // contains: false
            Console.WriteLine($"\nContains 5: {contains}");
        }
    
    }
}
