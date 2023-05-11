var addTwoNumbers = function(l1, l2) {
    let ret = new ListNode(0);
    let current = ret;
    let carry = 0;
    
    while (l1 !== null || l2 !== null) {
        let sum = carry;
        if (l1 !== null) {
            sum += l1.val;
            l1 = l1.next;
        }
        if (l2 !== null) {
            sum += l2.val;
            l2 = l2.next;
        }
        carry = Math.floor(sum / 10);
        current.next = new ListNode(sum % 10);
        current = current.next;
    }
    
    if (carry > 0) {
        current.next = new ListNode(carry);
    }
    
    return ret.next;
};


