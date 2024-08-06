using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue1._stack
{
    public class Stack
    {
        public Node top;
        public Stack() 
        {
            top = null;
        }

        public int Push( int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;

            return data;
        }

        public int Pop()
        {
            if (IsEmpty()) throw new Exception(" THe Stack is Empty ");
            int data = top.Data;
            top = top.Next;
            return data;
        }
        public int Peek()
        {
            if (IsEmpty()) throw new Exception(" The Stack is Empty ");
            return top.Data;
        }
        public bool IsEmpty() => top == null;

        public void Print()
        {
            Node current = top;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        //    stack stack = new stack();

        

    }
}
