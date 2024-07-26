using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue1._Queue
{
    public class Queue
    {
        Node front;
        Node rear;

        public Queue() 
        {
            front = null;
            rear = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }

           
        }

        public int Dequeue()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int value = front.Data;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            return value;
        }

        public int Peek()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
        public void Print()
        {
            Node? current = front;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

    }
}
