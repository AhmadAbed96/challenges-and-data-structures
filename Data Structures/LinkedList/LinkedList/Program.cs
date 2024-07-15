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

            LinkedLists linkedList = new LinkedLists();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(3);
            linkedList.Add(3);
            linkedList.Add(34);
            linkedList.Add(6);
            linkedList.print();
            Console.WriteLine("\t\t\t\tAfter Remove Duplicate");
            linkedList.RemoveDublicate();
            linkedList.print();
        }
    }
}
