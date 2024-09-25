namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();
            // Add List 
            //list.Add(1);
            //list.Add(2);
            //list.Add(8);
            //list.Add(9);
            // print the List 
            //list.print();

            // Remove from the list 
            //list.Remove(1);
            //Console.WriteLine("////////////////////////");
            //list.print();
            //Console.WriteLine(list.Includes(8));

            //LinkedLists linkedList = new LinkedLists();
            //linkedList.Add(1);
            //linkedList.Add(2);
            //linkedList.Add(2);
            //linkedList.Add(3);
            //linkedList.Add(3);
            //linkedList.Add(3);
            //linkedList.Add(34);
            //linkedList.Add(6);
            //linkedList.print();
            //Console.WriteLine("\t\t\t\tAfter Remove Duplicate");
            //linkedList.RemoveDublicate();
            //linkedList.print();

            //LinkedLists linkedList1 = new LinkedLists();
            //linkedList1.Add(3);
            //linkedList1.Add(1);
            //linkedList1.Add(9);
            //linkedList1.Add(7);
            //linkedList1.Add(15);
            //LinkedLists linkedList2 = new LinkedLists();
            //linkedList2.Add(4);
            //linkedList2.Add(12);
            //linkedList2.Add(5);
            //linkedList2.Add(7);
            //Console.WriteLine("\t\t\t\tLinkedList1 Before Sorted ");
            //Console.WriteLine();
            //linkedList1.print();
            //Console.WriteLine();

            //Console.WriteLine("\t\t\t\tLinkedList1 After Sorted ");
            //Console.WriteLine();
            //linkedList1.sortLinkedList();
            //Console.WriteLine();
            //linkedList1.print();
            //Console.WriteLine();
            //Console.WriteLine("\t\t\t\tLinkedList2 Before Sorted ");
            //Console.WriteLine();
            //Console.WriteLine();

            //linkedList2.print();
            //Console.WriteLine();
            //Console.WriteLine("\t\t\t\tLinkedList2 After Sorted ");
            //Console.WriteLine();
            //linkedList2.sortLinkedList();
            //Console.WriteLine();
            //linkedList2.print();    
            //Console.WriteLine();
            //Console.WriteLine("\t\t\t\tLinked List After Merge");
            //Console.WriteLine();
            //linkedList1.MergeSortedLists(linkedList2);
            LinkedLists list = new LinkedLists();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            list.RotateByK(4);
            list.PrintList();

        }
    }
}
