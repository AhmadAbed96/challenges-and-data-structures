using LinkedList;

namespace RotateLeftTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestRotatingByZero()
        {
            // Arrange
            LinkedLists list = new LinkedLists();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Act
            list.RotateByK(0);

            // Assert
            Assert.Equal(1, list.head.data);
            Assert.Equal(2, list.head.next.data);
            Assert.Equal(3, list.head.next.next.data);
            Assert.Equal(4, list.head.next.next.next.data);
            Assert.Equal(5, list.head.next.next.next.next.data);
        }


        [Fact]
        public void TestRotatingByValueGreaterThanListLength()
        {
            // Arrange
            LinkedLists list = new LinkedLists();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Act
            list.RotateByK(7);

            // Assert
            Assert.Equal(4, list.head.data);
            Assert.Equal(5, list.head.next.data);
            Assert.Equal(1, list.head.next.next.data);
            Assert.Equal(2, list.head.next.next.next.data);
            Assert.Equal(3, list.head.next.next.next.next.data);
        }
    }
}
