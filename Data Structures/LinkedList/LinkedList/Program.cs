namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            // Add List 
            list.Add(1);
            list.Add(2);
            list.Add(8);
            list.Add(9);
            // print the List 
            list.print();

            // Remove from the list 
            list.Remove(1);
            Console.WriteLine("////////////////////////");
            list.print();
            Console.WriteLine(list.Includes(8));
        }
    }
}
