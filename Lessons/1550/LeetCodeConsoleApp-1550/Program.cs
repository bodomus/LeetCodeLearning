// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var r = new Solution();
int[] arr = [1, 2, 34, 3, 4, 5, 7, 23, 12];
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($" 3 time ConsecutiveOdds exist {r.ThreeConsecutiveOdds(arr)}");


public class Solution
{
    public bool ThreeConsecutiveOdds(int[] data)
    {
        var ar = data.Select((value, index) => new { Index = index, Value = value }).ToArray();

        foreach (var item in ar)
        {
            Console.WriteLine($"Индекс: {item.Index}, Значение: {item.Value}");
        }

        int total = data.Count();
        for (int i = 0; i < total - 2; i++)
        {
            if (((ar[i].Value & 0x1) == 1) && ((ar[i + 1].Value & 0x1) == 1) && ((ar[i + 2].Value & 0x1) == 1)){
                return true;
            }
        }
        return false;
    }
}