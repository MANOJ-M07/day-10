using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsAppCircularDoublyLinked_list.Linkedlist;

namespace ConsAppCircularDoublyLinked_list
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
            first.next = linkedList.head;
            linkedList.head.next = first;
            Node second = new Node
            {
                data = 20,
                next = null,
                prev = first
            };
            first.next = second;
            second.next = linkedList.head;
            linkedList.head.prev = second;
            Node third = new Node
            {
                data = 21,
                next = null,
                prev=second
            };
            second.next = third;
            third.next = linkedList.head;
            linkedList.head.prev = third;

            linkedList.PrintDoublyCircularList();
            Console.ReadKey();

        }
    }
}
