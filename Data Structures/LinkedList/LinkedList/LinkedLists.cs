using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedLists
    {
        public Node head;
        public Node tail;
        public int count;
        public LinkedLists()
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
            if (head.data == val)
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
                        pre = i - 1;
                        break;
                    }
                    Newnode = Newnode.next;
                }
                Node newNode2 = head;
                for (int i = 0; i < count; i++)
                {
                    if (i == pre)
                    {
                        break;
                    }
                    newNode2 = newNode2.next;
                }

                newNode2.next = Newnode.next;
                Newnode.next = null;
                count--;

            }
        }

        public void RemoveDublicate()
        {
            if (head == null) return;
            Node current = head;
            while (current.next != null)
            {
                if (current.data == current.next.data)
                {
                    current.next = current.next.next;
                    count--;
                }
                else
                {
                    current = current.next;
                }

            }

        }

        public void RotateByK(int k)
        {
            if (head == null || k == 0) return;

            Node? current = head;
            int count = 1;
            while (count < k && current != null)
            {
                current = current.next;
                count++;
            }
            if (current == null) return;

            Node? kthNode = current;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = head;
            head = kthNode.next;
            kthNode.next = null;
        }
        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("\t\tHead ----> null");
                return;
            }

            Console.Write("\t\tHead ----> ");
            Node current = head;

            while (current != null)
            {

                Console.Write(current.data);

                if (current.next != null)
                    Console.Write(" --> ");

                current = current.next;
            }

            Console.WriteLine(" --> null");
        }

        public void MergeSortedLists(LinkedLists linkedlist)
            {
                count = 0;
                if (linkedlist == null && head == null) return;
                LinkedLists newlinkedList = new LinkedLists();
                sortLinkedList();
                linkedlist.sortLinkedList();
                Node current1 = head;
                Node current2 = linkedlist.head;
                while (current1 != null || current2 != null)
                {
                    if (current1 != null && (current2 == null || current1.data <= current2.data))
                    {
                        {
                            newlinkedList.Add(current1.data);
                            count++;
                            current1 = current1.next;
                        }
                    }
                    else if (current2 != null)
                    {
                        newlinkedList.Add(current2.data);
                        count++;
                        current2 = current2.next;
                    }
                }
                head = newlinkedList.head;
            }

             public void sortLinkedList()
             {
                List<int> list = new List<int>();
                if (head == null) return;
                while (head != null)
                {
                    list.Add(head.data);
                    head = head.next;
                }
                head = null;
                tail = null;
                foreach (var item in list.OrderBy(n => n).ToList())
                {
                    Add(item);
                }

             }

         
    }
}
