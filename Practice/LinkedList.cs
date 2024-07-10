using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    //Pair wise swapping of number in a linked list
    public class LinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        Node PairWiseSwap(Node node)
        {
            if (node == null || node.next == null)
            {
                return node;
            }
            Node prev = node;
            Node curr = node.next;
            node = curr;
            while (true)
            {
                Node next = curr.next;
                curr.next = prev;
                if (next == null || next.next == null)
                {
                    prev.next = next;
                    break;
                }
                prev.next = next.next;
                prev = next;
                curr = prev.next;
            }
            return node;
        }
        void PrintList(Node node)
        {
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }
        public static void Main(String[] args)
        {
            LinkedList list = new LinkedList();
            list.head = new Node(1);
            list.head.next = new Node(2);
            list.head.next.next = new Node(3);
            list.head.next.next.next = new Node(4);
            list.head.next.next.next.next = new Node(5);
            list.head.next.next.next.next.next = new Node(8);
            list.head.next.next.next.next.next.next = new Node(9);

            Console.WriteLine("Linked list before calling pairwiseSwap() ");
            list.PrintList(list.head);
            Node st = list.PairWiseSwap(list.head);
            Console.WriteLine("");
            Console.WriteLine("Linked list after calling pairwiseSwap() ");
            list.PrintList(st);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
