using StackAndQueue1._stack;
using StackAndQueue1._Queue;
using StackAndQueue1._stack.ReverseStackUsingQueue;

namespace StackAndQueue1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackWithReverse theStack = new StackWithReverse();
            theStack.Push(1);
            theStack.Push(2);
            theStack.Push(3);
            theStack.Push(4);
            Console.Write("\t\tThe Stack Items ==>\n");
            theStack.Print();

            Console.WriteLine("\t\t\tThe Stack Items after reverse ==>\n ");
            Console.WriteLine();
            theStack.ReverseStack();
            theStack.Print();
            Console.WriteLine();
            Console.Write("\t\tThe Stack Items ==>\n");
            Console.WriteLine();    
            theStack.Push(6);
            theStack.Push(7);
            theStack.Print();
            Console.WriteLine("\t\t\tThe Stack Items after reverse ==>\n ");
            Console.WriteLine();
            theStack.ReverseStack();
            theStack.Print();







        }
    }
}
