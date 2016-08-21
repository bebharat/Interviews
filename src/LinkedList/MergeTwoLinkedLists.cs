using DataStructures;

namespace LinkedList
{
    public class MergeTwoLinkedLists
    {
        public LinkedListNode Merge(LinkedListNode list1, LinkedListNode list2)
        {
            LinkedListNode result = null;

            if (list1 == null && list2 == null)
                return result;

            if (list1 == null) return list2;
            if (list2 == null) return list1;

            if (list1.Value < list2.Value)
            {
                result = list1;
                result.Next = Merge(list1.Next, list2);
            }
            else
            {
                result = list2;
                result.Next = Merge(list1, list2.Next);
            }

            return result;
        }   
    }
}
