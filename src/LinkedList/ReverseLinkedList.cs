using DataStructures;


namespace LinkedList
{
    public class ReverseLinkedList
    {
        public LinkedListNode HEAD { get; private set; }

        public LinkedListNode Reverse(LinkedListNode head)
        {
            LinkedListNode current = head;
            LinkedListNode prev = null;

            while(current != null)
            {
                LinkedListNode next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }

        public LinkedListNode Reverse_Recursively(LinkedListNode node)
        {
            ReverseRecursively(node);
            return HEAD;
        }

        private LinkedListNode ReverseRecursively(LinkedListNode node)
        {
            if (node.Next == null)
            {
                HEAD = node;
                return node;
            }
            
            var prev = ReverseRecursively(node.Next);
            prev.Next = node;
            node.Next = null;
            return node;
        }
    }
}
