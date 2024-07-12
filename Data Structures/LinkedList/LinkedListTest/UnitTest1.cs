using Xunit;
using System.Runtime.CompilerServices;
using LinkedList;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void Remove_NodeIsTail_NodeIsRemoved()
        {
            // Arrange
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            // Act
            linkedList.Remove(3);

            // Assert
            Assert.Equal( "false",linkedList.Includes(3));
            
        }

        [Fact]
        public void Print_ListContainsNodes_PrintsAllNodes()
        {
            // Arrange
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                linkedList.print();

                // Assert
                var expectedOutput = string.Format("1{0}2{0}3{0}", Environment.NewLine);
                Assert.Equal(expectedOutput, sw.ToString());
            }
        }
    }
}