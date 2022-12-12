/* You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        // if either of the input lists is empty, return the other list
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        
        // create a new ListNode with a value of 0 and a next reference of null
        var newHead = new ListNode(0); 
        
        // create a new ListNode called runnerHead and set its next reference to newHead
        var runnerHead = new ListNode(0); 
        
        // continue looping until either l1 or l2 becomes null
        while(l1 != null && l2 != null)
        {
            // if val of l1 is greater than or equal to the value in l2, set the next reference of runnerHead to l2 and move l2 to the next node in the list
            if (l1.val >= l2.val)
            {
                runnerHead.next = l2;
                l2 = l2.next;
            }
            // else set the next reference of runnerHead to l1 and move l1 to the next node in the list
            else
            {
                runnerHead.next = l1;
                l1 = l1.next;
            }
            
            // set runnerHead to the next node in the list
            runnerHead = runnerHead.next;
        }
        
        // if l1 is not null at the end of the while loop, set the next reference of runnerHead to l1
        if (l1 != null) runnerHead.next = l1;
        
        if (l2 != null) runnerHead.next = l2;
        
        // return the merged list without the first value!
        return newHead.next;
    }



    //solution without ListNode
    public List<int> MergeTwoLists(List<int> l1, List<int> l2) 
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        while(l1.Count > 0 && l2.Count > 0)
        {
            if (l1[0] >= l2[0])
            {
                mergedList.Add(l2[0]);
                l2.RemoveAt(0);
            }
            else
            {
                mergedList.Add(l1[0]);
                l1.RemoveAt(0);
            }
        }
    
        mergedList.AddRange(l1);
        mergedList.AddRange(l2);
    
        return mergedList;
    }

}
