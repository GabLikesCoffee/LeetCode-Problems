
//Definition for singly-linked list.

public class ListNode {
    int val;
    ListNode next;
    ListNode() {}
    ListNode(int val) { this.val = val; }
    ListNode(int val, ListNode next) { this.val = val; this.next = next; }
}

class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        ListNode retList = new ListNode(0);
        ListNode currentRet = retList;

        while(l1 != null || l2 != null){
            int sum = carry;

            if(l1 != null){
                sum += l1.val;
                l1 = l1.next;
            }
            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }
            carry = sum / 10;
            sum = sum % 10;

            currentRet.next = new ListNode(sum);
            currentRet = currentRet.next;
        }
        if(carry > 0){
            currentRet.next = new ListNode(carry);
            currentRet = currentRet.next;
        }
        return retList.next;   
    }
}