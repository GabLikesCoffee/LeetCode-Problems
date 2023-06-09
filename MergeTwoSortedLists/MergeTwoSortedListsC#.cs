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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode list = new ListNode();
        ListNode ret = list;

        while(list1 != null || list2 != null){
            if(list1 != null && list2 != null){
                if(list1.val < list2.val){
                    list.next = new ListNode(list1.val);
                    list = list.next;
                    list1 = list1.next;
                }
                else{
                    list.next = new ListNode(list2.val);
                    list = list.next;
                    list2 = list2.next;
                }
            }
            else if(list1 != null){
                list.next = new ListNode(list1.val);
                list = list.next;
                list1 = list1.next;
            }
            else{
                list.next = new ListNode(list2.val);
                list = list.next;
                list2 = list2.next;
            }
        }
        return ret.next;
    }
}