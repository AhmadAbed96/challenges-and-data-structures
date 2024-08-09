using StackAndQueue1._stack;
using StackAndQueue1._Queue;
using StackAndQueue1._stack.ReverseStackUsingQueue;
using StackAndQueue1._stack.Remove_Middle_Element_Stack;
using StackAndQueue1._stack.Min_Stack;

namespace StackAndQueue1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StackWithReverse theStack = new StackWithReverse();
            //theStack.Push(1);
            //theStack.Push(2);
            //theStack.Push(3);
            //theStack.Push(4);
            //Console.Write("\t\tThe Stack Items ==>\n");
            //theStack.Print();

            //Console.WriteLine("\t\t\tThe Stack Items after reverse ==>\n ");
            //Console.WriteLine();
            //theStack.ReverseStack();
            //theStack.Print();
            //Console.WriteLine();
            //Console.Write("\t\tThe Stack Items ==>\n");
            //Console.WriteLine();    
            //theStack.Push(6);
            //theStack.Push(7);
            //theStack.Print();
            //Console.WriteLine("\t\t\tThe Stack Items after reverse ==>\n ");
            //Console.WriteLine();
            //theStack.ReverseStack();
            //theStack.Print();

            //RemoveMidleElement stack = new RemoveMidleElement();
            //stack.Push(7);
            //stack.Push(14);
            //stack.Push(3);
            //stack.Push(8);
            //stack.Push(5);

            //stack.Print(); // Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7
            //stack.DeleteMiddle();
            //Console.WriteLine("After deleting middle element");
            //stack.Print(); // Stack: Top -> 5 -> 8 -> 14 -> 7

            //Console.WriteLine("///////////////////////////////////////////");

            //stack.Push(2);
            //stack.Push(9);
            //stack.Push(11);
            //stack.Print(); // Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7
            //Console.WriteLine("After deleting middle element");

            //stack.DeleteMiddle();
            //stack.Print(); // Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7
            minStack minStack = new minStack();
            minStack.Push(15); // Top -> 15 (min: 15)
            minStack.Print();
            Console.WriteLine($"   ├--min: {minStack.GetMin()}");
            minStack.GetMin();

            minStack.Push(7);  // Top -> 7 -> 15 (min: 7) 
            minStack.Print();

            Console.WriteLine($"   ├--min: {minStack.GetMin()}");


            minStack.Push(12); // Top -> 12 -> 7 -> 15 (min: 7)
            minStack.Print();

            Console.WriteLine($"   ├--min: {minStack.GetMin()}");


            minStack.Push(3);  // Top -> 3 -> 12 -> 7 -> 15 (min: 3) 
            minStack.Print();


            Console.WriteLine($"   ├--min: {minStack.GetMin()}");


            Console.WriteLine("Pop a node from the stack");
            minStack.Pop(); // popped: 3
            minStack.Print(); // Output: Top -> 12 -> 7 -> 15
            Console.WriteLine($"   ├--min: {minStack.GetMin()}");





        }
    }
}
