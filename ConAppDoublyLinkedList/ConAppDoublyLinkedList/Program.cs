using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDoublyLL
{

    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node first = new Node
            {
                data = 12,
                next = null,
                prev = null
            };
            linkedList.head = first;
            Node second = new Node
            {
                data = 20,
                next = null
            };
            first.next = second;
            second.prev = first;
            Node third = new Node
            {
                data = 21,
                next = null
            };
            second.next = third;
            third.prev = second;
            linkedList.PrintList();
            linkedList.InsertAtEnd(50);
            Console.WriteLine("After inserting item 50");
            linkedList.PrintList();
            linkedList.InsertAtEnd(67);
            Console.WriteLine("After Inserting Item 67");
            linkedList.PrintList();
            Console.ReadKey();

        }
    }
}