using System.Text;
using TreeImplementation;

namespace Right_TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestRightView()
        {
            // Arrange
            StringBuilder output = new StringBuilder();
            Binary_Tree tree = new Binary_Tree(2);
            tree.Root.left = new TNode(3);
            tree.Root.Right = new TNode(5);
            tree.Root.left.left = new TNode(4);
            tree.Root.Right.Right = new TNode(6);
            tree.Root.left.left.Right = new TNode(7);

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                tree.PrintRightView();
                var result = sw.ToString().Trim().Replace("\r", "");
                Assert.Equal("2 5 6 7", result);
            }
        }

        [Fact]
        public void TestRightSkewedTree()
        {
            // Arrange
            Binary_Tree tree = new Binary_Tree(1);
            tree.Root.Right = new TNode(2);
            tree.Root.Right.Right = new TNode(3);

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                tree.PrintRightView();
                var result = sw.ToString().Trim().Replace("\r", "");
                Assert.Equal("1 2 3", result);
            }
        }
    }
}