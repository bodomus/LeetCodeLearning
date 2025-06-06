// See https://aka.ms/new-console-template for more information
//     Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//     You may assume that each input would have exactly one solution, and you may not use the same element twice.
//     You can return the answer in any order.
using LeetCodeConsoleApp_2;

var run = new Master();

class Master
{
    public Master()
    {
        int[] a1 = new int []{2, 4, 3 };
        int[] a2 = {5, 6, 4};
        
        ListNode l1 = ListNode.CreateLinkList(a1), l2 = ListNode.CreateLinkList(a2);
        var mySolution = new MySolution();
        mySolution.AddTwoNumbers(l1, l2);
    }
}

