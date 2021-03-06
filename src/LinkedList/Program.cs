﻿using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListNode n = new LinkedListNode(10);
            n.Next = new LinkedListNode(20);
            n.Next.Next = new LinkedListNode(30);
            n.Next.Next.Next = new LinkedListNode(40);

            LinkedListNode m = new LinkedListNode(5);
            m.Next = new LinkedListNode(25);
            m.Next.Next = new LinkedListNode(30);
            m.Next.Next.Next = new LinkedListNode(37);

            //var obj = new ReverseLinkedList();
            //var reverseList = obj.Reverse(n);

            //var obj = new ReverseLinkedList();
            //var reverseList = obj.Reverse_Recursively(n);

            //var obj = new RemoveKthNode();
            //var afterRemoval = obj.DeleteK(n, 2);

            var obj = new MergeTwoLinkedLists();
            var afterMerge = obj.Merge(n,m);

            Console.ReadLine();
        }
    }
}
