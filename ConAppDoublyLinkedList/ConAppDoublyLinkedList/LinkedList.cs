using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDoublyLL
{
    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;

        }
        public void InsertAtEnd(int newElement)
        {
            Node newnode = new Node();
            newnode.data = newElement;
            newnode.next = null;
            newnode.prev = null;
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                Node temp = new Node();
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = newnode;
                newnode.prev = temp;
            }
        }
        public void PrintList()
        {

            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.WriteLine("The List Contains");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("This List is empty");
            }
        }
    }
}