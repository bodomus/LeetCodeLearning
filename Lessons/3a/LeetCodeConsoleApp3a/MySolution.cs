namespace LeetCodeConsoleApp_3;

public class MySolution
{
    // public int LengthOfLongestSubstring(string s)
    // {
    //     int start = 0;
    //     int tail = 1;
    //     string substr = s.Substring(start, tail - start);
    //     string next = s.Substring(1, 1);
    //     int index = -1;
    //     int maxs = 0;
    //     while (tail < s.Length)
    //     {
    //         index = substr.IndexOf(next);
    //         if (index < 0)
    //         {
    //             tail++;
    //             
    //             if (tail == s.Length)
    //                 break;
    //             substr = s.Substring(start, tail - start);
    //             next = s.Substring(tail, 1);
    //             maxs = maxs < substr.Length ? substr.Length : maxs;
    //         }
    //         else
    //         {
    //             start = start + index + 1;
    //             substr = s.Substring(start, tail - start);
    //         }
    //     }
    //     return maxs;
    // }
    
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        // Для Unicode-символов используйте Dictionary<char,int>.
        Span<int> last = stackalloc int[128]; // ASCII: заполняем −1
        for (int i = 0; i < last.Length; i++) last[i] = -1;

        int maxLen = 0;
        int start  = 0;                       // левая граница окна

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            int prev = last[c];

            if (prev >= start)                // повторы внутри текущего окна
                start = prev + 1;             // сдвигаем левую границу

            last[c] = i;                      // запоминаем позицию символа
            maxLen  = Math.Max(maxLen, i - start + 1);
        }
        return maxLen;
    }

}