using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node first = new Node
            {
                data = 12,
                next = null
            };
            linkedList.head = first;
            Node Second = new Node
            {
                data = 13,
                next = null
            };
            first.next = Second;
            Node third = new Node
            {
                data = 14,
                next = null
            };
            Second.next = third;
            linkedList.PrintLList();
            Console.ReadKey();  
        }
    }
}
