using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue1._stack
{
    public class Stack
    {
        Node top;
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
            if (ISEmpty()) throw new Exception(" THe Stack is Empty ");
            int data = top.Data;
            top = top.Next;
            return data;
        }
        public int Peek()
        {
            if (ISEmpty()) throw new Exception(" THe Stack is Empty ");
            return top.Data;
        }
        public bool ISEmpty() => top == null;

        public void Print()
        {
            Node current = top;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

    }
}
