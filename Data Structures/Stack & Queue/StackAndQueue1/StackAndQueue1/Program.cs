using StackAndQueue1._stack;
using StackAndQueue1._Queue;

namespace StackAndQueue1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();
            Queue queue = new Queue();
            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Peek() == 5);

            stack.Pop();
            Console.WriteLine(stack.Peek() == 4);

            stack.Print();

            Console.WriteLine("--------------------------------");

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Print();

            queue.Dequeue();
            Console.WriteLine("\n After dequeue \n");
            queue.Print();





        }
    }
}
