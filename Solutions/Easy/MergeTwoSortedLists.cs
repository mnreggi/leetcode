namespace Solutions.Easy;

/// <summary>
/// You are given the heads of two sorted linked lists list1 and list2.
/// Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
/// Return the head of the merged linked list.
/// </summary>
public class MergeTwoSortedLists
{
     public class ListNode {
         public int val;
         public ListNode? next;
         public ListNode(int val=0, ListNode? next=null) 
         {
             this.val = val;
             this.next = next;
         }
     }

     /// <summary>
     /// Scenarios:
     /// 1- null, null
     /// 2- [], []
     /// 3- null, 1->2
     /// 4- All same value. E.g: 1->1->1 , 1->1->1
     /// 5- Or 1->1->1->1, 0->0
     /// 6- 1->2, 99->100
     /// 7- 1, 5->6->7->1000
     /// 8- Is there a max value?
     /// </summary>
     /// <param name="list1"></param>
     /// <param name="list2"></param>
     /// <returns></returns>
     public ListNode MergeTwoLists(ListNode? list1, ListNode? list2)
     {
         if (list1 == null)
         {
             return list2;
         }
         
         if (list2 == null)
         {
             return list1;
         }
         
         // While loop
         
         var dummyNode = new ListNode();
         var node = dummyNode;
         
         while (list1 != null && list2 != null)
         {
             if (list1.val < list2.val)
             {
                 dummyNode.next = list1;
                 list1 = list1.next;
             }
             else
             {
                 dummyNode.next = list2;
                 list2 = list2.next;
             }

             // node = node.next;
         }

         if (list1 == null)
         {
             node.next = list2;
         }

         if (list2 == null)
         {
             node.next = list1;
         }
         
         // // Recursive way
         //
         // if (list1.val < list2.val)
         // {
         //     list1.next = MergeTwoLists(list1.next, list2);
         //     return list1;
         // }
         // else
         // {
         //     list2.next = MergeTwoLists(list1, list2.next);
         //     return list2;
         // }

         return dummyNode.next;
     }
}