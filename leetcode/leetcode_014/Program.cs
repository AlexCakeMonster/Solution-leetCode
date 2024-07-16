using System;

namespace leetcode_014
{
    class Program
    {
        /*                                                                                                                                      
        Medium
        
        You are given two non-empty linked lists representing two non-negative integers.
        The digits are stored in reverse order, and each of their nodes contains a single digit. 
        Add the two numbers and return the sum as a linked list.
        You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        The number of nodes in each linked list is in the range [1, 100].
        0 <= Node.val <= 9
        It is guaranteed that the list represents a number that does not have leading zeros.

        
        1569 / 1569 test cases passed. Status: Accepted
        Runtime: 59 ms  beats 98.85 % of csharp submissions.
        Memory Usage: 52.3 MB   beats 9.52 % of csharp submissions. average of all users 51.3 MB
         */
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(2, new ListNode(4,new ListNode(9, new ListNode())));
            ListNode list2 = new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(9, new ListNode()))));
            ListNode result = new Solution().AddTwoNumbers(list1, list2); //6
            while(result.next != null)
            {
                Console.Write(result.val);
                result = result.next;
            }

        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode nexListNode = null;            
            ListNode resultListNode = new ListNode();
            System.Collections.Generic.Queue<int> digitL1 = new System.Collections.Generic.Queue<int>();
            System.Collections.Generic.Queue<int> digitL2 = new System.Collections.Generic.Queue<int>();
            System.Collections.Generic.Stack<int> result = new System.Collections.Generic.Stack<int>();
            int remainderOfAddition = 0;
            int sum = 0;
            nexListNode = l1;
            while (nexListNode.next != null)
            {
                digitL1.Enqueue(nexListNode.val);                
                nexListNode = nexListNode.next;
            }
            nexListNode = l2;
            while (nexListNode.next != null)
            {
                digitL2.Enqueue(nexListNode.val);                
                nexListNode = nexListNode.next;                
            }
            
            while (digitL1.Count != 0 && digitL2.Count != 0)
            {                
                sum = digitL1.Dequeue() + digitL2.Dequeue() + remainderOfAddition;
                if (sum < 10)
                {
                    result.Push(sum);
                    remainderOfAddition = 0;
                }                    
                else
                {
                    remainderOfAddition = 1;
                    result.Push(sum % 10);
                }            

            }

            while (digitL1.Count != 0)
            {
                sum = digitL1.Dequeue() + remainderOfAddition;

                if (sum < 10)
                {
                    result.Push(sum);
                    remainderOfAddition = 0;
                }
                else
                {
                    remainderOfAddition = 1;
                    result.Push(sum % 10);
                }
            }

            while (digitL2.Count != 0)
            {
                sum = digitL2.Dequeue() + remainderOfAddition;

                if (sum < 10)
                {
                    result.Push(sum);
                    remainderOfAddition = 0;
                }
                else
                {
                    remainderOfAddition = 1;
                    result.Push(sum % 10);
                }
            }

            if(remainderOfAddition == 1)
                result.Push(1);

            while (result.Count != 0)
            {
                resultListNode = new ListNode(result.Pop(), resultListNode);
            }

            return resultListNode;
        }

        
    }

    public class ListNode
    {

        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {

            this.val = val;
            this.next = next;
        }
    }


}
