/*Given the head of a singly linked list, reverse the list, and return the reversed list.*/
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
    public ListNode ReverseList(ListNode head) 
    {
        ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}


/* JS SOLUTION: 
class ListNode {
        constructor(value) {
            this.value = value;
            this.next = null;
        }
    }
    
    function reverseList(head) {
        let prev = null;
        let current = head;
        let next = null;
    
        while (current !== null) {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
    
        return prev;
    }
    
    
    let head = new ListNode(1);
    head.next = new ListNode(2);
    head.next.next = new ListNode(3);
    head.next.next.next = new ListNode(4);
    head.next.next.next.next = new ListNode(5);
    
    // Reverse the linked list
    let reversedHead = reverseList(head);
    */