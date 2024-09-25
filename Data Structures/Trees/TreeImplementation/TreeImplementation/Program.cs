using System.ComponentModel;

namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Binary_Search_Tree binarySearchTree = new Binary_Search_Tree(3);
            //binarySearchTree.Add(8);
            //binarySearchTree.Add(2);
            //binarySearchTree.Add(1);
            //binarySearchTree.Add(5);
            //binarySearchTree.Add(7);
            //Console.WriteLine("Pre-Order-Traversal");
            //binarySearchTree.Pre_Order(binarySearchTree.Root);

            //Console.WriteLine();
            //Console.WriteLine("In-Order-Traversal");

            //binarySearchTree.In_Order(binarySearchTree.Root);
            //Console.WriteLine();
            //Console.WriteLine("Post-Order-Traversal");
            //Console.WriteLine("Remove 8");

            //binarySearchTree.Remove(8);

            //binarySearchTree.Post_Order(binarySearchTree.Root);

            //bool contains = binarySearchTree.Contain(5); // contains: false
            //Console.WriteLine($"\nContains 5: {contains}");

            //Binary_Tree Btree = new Binary_Tree(4);

            //Btree.Root.left = new TNode(8);
            //Btree.Root.Right = new TNode(7);
            //Btree.Root.left.left = new TNode(12);
            //Btree.Root.left.Right = new TNode(9);
            //Console.WriteLine("InOrder - Treversal");
            //Btree.In_Order(Btree.Root);
            //Btree.Mirror();
            //Console.WriteLine();
            //Console.WriteLine("Arter Using Mirror method");

            //Console.WriteLine();
            //Btree.In_Order(Btree.Root);

            //Btree.Root.left = new TNode(8);
            //Btree.Root.Right = new TNode(7);
            //Btree.Root.left.left = new TNode(12);
            //Btree.Root.left.Right = new TNode(9);
            //Btree.Root.left.Right = new TNode(10);
            //Btree.Root.left.Right = new TNode(13);
            //Btree.Add(11);
            //Btree.Add(14);
            //Btree.Add(17);
            //Btree.Add(19);

            //Console.WriteLine("InOrder - Treversal");
            //Btree.Pre_Order(Btree.Root);
            //Console.WriteLine();
            //Console.WriteLine("The Second Max Vaalue is");
            //Console.WriteLine();
            //Console.WriteLine(Btree.SecondMax(Btree.Root));

            //Btree.Root = new TNode(10);
            //Btree.Root.left = new TNode(8);
            //Btree.Root.Right = new TNode(12);
            //Btree.Root.left.left = new TNode(4);
            //Btree.Root.left.Right = new TNode(7);
            //Btree.Root.Right.left = new TNode(15);
            //Btree.Root.Right.Right = new TNode(23);
            //Btree.Root.left.left.Right = new TNode(3);


            //Console.WriteLine("Pre-Order Traversal:");
            //Btree.Pre_Order(Btree.Root);
            //Console.WriteLine();


            //int leafSum = Btree.LeafSum();
            //Console.WriteLine("The sum of all leaf nodes is:");
            //Console.WriteLine(leafSum);

            Binary_Tree Btree = new Binary_Tree(5);

            Btree.Root.left = new TNode(13);
            Btree.Root.Right = new TNode(7);
            Btree.Root.left.left = new TNode(3);
            Btree.Root.left.Right = new TNode(7);
            Btree.Root.Right.left = new TNode(12);
            Btree.Root.Right.Right = new TNode(20);
            Btree.Root.left.left.left = new TNode(1);
            Btree.Root.left.left.Right = new TNode(4);
            Btree.Root.Right.left.Right = new TNode(11);

            List<int> largestValues = Btree.LargestValueEachLevel();

            // Print the largest values at each level
            Console.WriteLine("Largest values at each level: " + string.Join(", ", largestValues));


        }
    
    }
}
