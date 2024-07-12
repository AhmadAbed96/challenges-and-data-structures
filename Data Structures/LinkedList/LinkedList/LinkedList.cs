using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;
        public Node tail;
        public int count;
        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool isEmpty()
        {
            if (head == null)
                return true;
            else
            {
                return false;
            }
        }
        public void insertToHead(int val)
        {
            if (isEmpty())
            {
                head = new Node();
                tail = new Node();
                head.data = val;
                head.next = null;
                tail = head;
                count++;
            }
            else 
            {
                Node newNode = new Node();
                newNode.data = val;
                newNode.next = head;
                head = newNode;
                count++;

            }
        }
        public void Add(int val) 
        {
            if (isEmpty())
            {
                insertToHead(val);
            }
            else
            {
                Node NewNode = new Node();
                NewNode.data = val;
                NewNode.next = null;
                tail.next = NewNode;
                tail = NewNode; 
                count++;

            }
        }

        public string Includes(int val)
        {
            if (head == null) return "false";

            Node Newnode = head;

            for (int i = 0; i < count; i++)
            {
                if (val == Newnode.data)
                   return "true";
               Newnode = Newnode.next;
            }
            return "false";
        }

        public void Remove(int val)
        {
            Node Newnode = head;
            if(head.data == val)
            {
                head = Newnode.next;
                Newnode.next = null;
                count--;
            }
            else
            {
                int pre = 0;

            for (int i = 0; i < count; i++)
            {
                if (val == Newnode.data)
                {
                    pre = i-1;
                    break;
                }
                Newnode = Newnode.next;
            }
            Node newNode2 = head;
            for (int i = 0; i < count; i++)
            {
                if(i == pre)
                {
                    break;
                }
                newNode2 = newNode2.next;
            }
            
            newNode2.next = Newnode.next ;
            Newnode.next = null;
            count--;

            }
        }

        public void print() 
        {
            Node node = head;   
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(node.data);
                node = node.next;

            }
        }
    }
}
