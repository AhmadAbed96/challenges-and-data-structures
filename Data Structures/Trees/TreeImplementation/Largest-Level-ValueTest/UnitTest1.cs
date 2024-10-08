using TreeImplementation;

namespace MaxLevelTest
{
    public class UnitTest1
    {
        [Fact]
        public void LargestValueEachLevel_SumOfLargestValues_IsCorrect()
        {
            // Arrange
            var binaryTree = new Binary_Tree(10);
            binaryTree.Root.left = new TNode(7);
            binaryTree.Root.Right = new TNode(15);
            binaryTree.Root.left.left = new TNode(5);
            binaryTree.Root.left.Right = new TNode(9);
            binaryTree.Root.Right.left = new TNode(11);
            binaryTree.Root.Right.Right = new TNode(20);

            // Act
            var largestValues = binaryTree.LargestValueEachLevel();
            int actualSum = 0;
            foreach (int value in largestValues)
            {
                actualSum += value;
            }

            // Assert
            int expectedSum = 45;
            Assert.Equal(expectedSum, actualSum);
        }
    }
}