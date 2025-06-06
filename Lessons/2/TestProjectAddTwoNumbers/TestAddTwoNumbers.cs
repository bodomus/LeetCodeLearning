using AutoFixture;
using LeetCodeConsoleApp_2;

namespace TestProjectAddTwoNumbers;

public class TestAddTwoNumbers
{
    private readonly Fixture _fixture = new Fixture();
    private MySolution test = new MySolution(); 
    
    [Fact]
    public void Test1()
    {
        int[] a1 = new int []{9};
        int[] a2 = {1,9,9,9,9,9,9,9,9,9};
        
        ListNode l1 = ListNode.CreateLinkList(a1);
        ListNode l2 = ListNode.CreateLinkList(a2);

        var r = test.AddTwoNumbers(l1, l2);

        var check = ListNode.GetNumbers(r);
    }
    
    [Fact]
    public void Test2()
    {
        int[] a1 = new int []{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1};
        int[] a2 = {5,6,4};
        
        ListNode l1 = ListNode.CreateLinkList(a1);
        ListNode l2 = ListNode.CreateLinkList(a2);

        var r = test.AddTwoNumbers(l1, l2);

        var check = ListNode.GetNumbers(r);
    }
    
    [Fact]
    public void Test3()
    {
        int[] a1 = new int []{2,4,3};
        int[] a2 = {5,6,4};
        
        ListNode l1 = ListNode.CreateLinkList(a1);
        ListNode l2 = ListNode.CreateLinkList(a2);

        var r = test.AddTwoNumbers(l1, l2);

        var check = ListNode.GetNumbers(r);
    }
}