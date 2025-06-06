using System.Collections;

namespace LeetCodeConsoleApp_2;




public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode CreateLinkList(int [] data)
    {
        ListNode? next = null;
        // ListNode head = data
        //     .Reverse()                               // перебираем элементы в обратном порядке
        //     .Aggregate(                              // «сворачиваем» коллекцию в единственный результат
        //         seed: (ListNode)null,                // начальное значение (prev из цикла)
        //         func: (next, value) => new ListNode(value, next)); // создаём узел и продвигаем «prev»
        foreach (var i in data.Reverse())
        {
            ListNode ln = new ListNode(i, next);
            next = ln;
        }
        return next;
    }

    public static int GetNumbers(ListNode head)
    {
        int result = 0;   
        int mult   = 1;   

        for (var node = head; node != null; node = node.next)
        {
            result += node.val * mult; // кладём очередную «цифру» в нужный разряд
            mult   *= 10;              // продвигаем позицию разряда
        }
        return result;                 // например 1→2→3 даст 321
    }
}
