using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSinglyLinkedList
{
    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;

        }

        public void PrintLList()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null )
            {
                Console.WriteLine("the List contains");
                while ( temp != null )
                {
                    Console.WriteLine(temp.data+"");
                    temp = temp.next;
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("the L List is empty");
            }
        }
    }
}
