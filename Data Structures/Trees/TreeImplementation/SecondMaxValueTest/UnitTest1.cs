using TreeImplementation;

namespace SumLeafTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestLeafSumWithPositiveValues()
        {
            // Arrange
            var tree = new Binary_Tree(3);
            tree.Root.Right = new TNode(3);
            tree.Root.Right.left = new TNode(4);
            tree.Root.Right.Right = new TNode(5);
            tree.Root.left = new TNode(2);
            tree.Root.left.Right = new TNode(6);
            tree.Root.left.left = new TNode(1);



            // Act
            int result = tree.LeafSum();

            // Assert
            Assert.Equal(16, result);
        }

        [Fact]
        public void TestLeafSumWithNegativeValues()
        {
            // Arrange
            var tree = new Binary_Tree(-3);
            tree.Root.Right = new TNode(-3);
            tree.Root.Right.left = new TNode(-4);
            tree.Root.Right.Right = new TNode(-5);
            tree.Root.left = new TNode(-2);
            tree.Root.left.Right = new TNode(-6);
            tree.Root.left.left = new TNode(-1);

            // Act
            int result = tree.LeafSum();

            // Assert
            Assert.Equal(-16, result);
        }
    }
}