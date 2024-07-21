
using LinkedList;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
namespace MergeSortedTest
{
    public class UnitTest1
    {
        [Fact]
        public void MergeSortedTestWhenOneLinkedListisEmpty()
        {
            LinkedLists linkedList1 = new LinkedLists();
            linkedList1.Add(4);
            linkedList1.Add(1);

            linkedList1.Add(6);

            LinkedLists linkedList2 = new LinkedLists();

            linkedList1.MergeSortedLists(linkedList2);
            Assert.NotNull(linkedList1.head);
            Assert.Equal(1, linkedList1.head.data);
            Assert.Equal(4, linkedList1.head.next.data);
            Assert.Equal(6, linkedList1.head.next.next.data);
            Assert.Null(linkedList1.head.next.next.next);

        }
        [Fact]
        public void MergeSortedTestWhenTwoLinkedListisEmpty()
        {
            LinkedLists linkedList1 = new LinkedLists();


            LinkedLists linkedList2 = new LinkedLists();

            linkedList1.MergeSortedLists(linkedList2);


            Assert.Null(linkedList1.head);

        }
        [Fact]
        public void MergeSortedTestWhenTwoLinkedListisNotEmpty()
        {
            LinkedLists linkedList1 = new LinkedLists();
            linkedList1.Add(5);
            linkedList1.Add(10);

            linkedList1.Add(15);

            LinkedLists linkedList2 = new LinkedLists();
            linkedList2.Add(2);
            linkedList2.Add(3);
            linkedList2.Add(20);

            linkedList1.MergeSortedLists(linkedList2);
            Assert.NotNull(linkedList1.head);
            Assert.Equal(2, linkedList1.head.data);
            Assert.Equal(3, linkedList1.head.next.data);
            Assert.Equal(5, linkedList1.head.next.next.data);
            Assert.Equal(10, linkedList1.head.next.next.next.data);
            Assert.Equal(15, linkedList1.head.next.next.next.next.data);
            Assert.Equal(20, linkedList1.head.next.next.next.next.next.data);
            Assert.Null(linkedList1.head.next.next.next.next.next.next);

        }
    }
}