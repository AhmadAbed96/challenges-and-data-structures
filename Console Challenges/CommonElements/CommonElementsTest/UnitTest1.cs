using CommonElements;
namespace CommonElementsTest
{
    public class UnitTest1
    {
       
      
        
            [Fact]
            public void CommonList()
            {
                // Arrange
                int[] array1 = { 1, 2, 3, 0 };
                int[] array2 = { 2, 3, 4, 9 };
                int[] array3 = { 79, 8, 15 };
                int[] array4 = { 23, 79, 8 };

                //Act
                List<int> list = Program.commonElements(array1, array2);
                List<int> list2 = Program.commonElements(array3, array4);

                //Assert
                Assert.Equal(2, list.Count);
                Assert.Equal(2, list2.Count);
            }
        
    }
}