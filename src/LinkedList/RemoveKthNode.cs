using DataStructures;
using System;

namespace LinkedList
{
    public class RemoveKthNode
    {
        public LinkedListNode DeleteK(LinkedListNode node, int k)
        {
            if( k == 0 || node == null) return node;

            if( k == 1)
            {
                node.Next = null;
                return node;
            }

            int count = 0;

            LinkedListNode prev = node;
            LinkedListNode current = node.Next;

            while(current != null)
            {
                count++;

                if(count % k == 0)
                {
                    Console.WriteLine("Removed " + current.Value);
                    prev.Next = current.Next;
                }

                prev = current;
                current = current.Next;
            }

            return node;
        }
    }
}
